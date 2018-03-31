using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimization
{
    public partial class MainForm : Form
    {
        double A = 1, B = 1, C = 0, D = 0;
        double Eps = 1E-5, FEps=0;
        int NumSteps = 30, FNumSteps=0;
        double R = 2;
        List<double> Points = new List<double>();
        MyPoint Res;
        double X1 = 0, X2 = 1;
        Method method = null;

        public MainForm()
        {
            InitializeComponent();

            textBoxA.Text = A.ToString();
            textBoxB.Text = B.ToString();
            textBoxC.Text = C.ToString();
            textBoxD.Text = D.ToString();
            textBoxEps.Text = Eps.ToString();
            textBoxNumSteps.Text = NumSteps.ToString();
            textBoxR.Text = R.ToString();
            textBoxX1.Text = X1.ToString();
            textBoxX2.Text = X2.ToString();
        }

        private bool CheckData()
        {
            if (!Double.TryParse(textBoxA.Text, out A)) { MessageBox.Show("Неверный параметр a"); return false; }
            if (!Double.TryParse(textBoxB.Text, out B)) { MessageBox.Show("Неверный параметр b"); return false; }
            if (!Double.TryParse(textBoxC.Text, out C)) { MessageBox.Show("Неверный параметр c"); return false; }
            if (!Double.TryParse(textBoxD.Text, out D)) { MessageBox.Show("Неверный параметр d"); return false; }
            if (!Double.TryParse(textBoxX1.Text, out X1)) { MessageBox.Show("Неверный параметр x1"); return false; }
            if (!Double.TryParse(textBoxX2.Text, out X2)) { MessageBox.Show("Неверный параметр x2"); return false; }
            if (!Double.TryParse(textBoxEps.Text, out Eps)) { MessageBox.Show("Неверный параметр eps"); return false; }
            if (!Int32.TryParse(textBoxNumSteps.Text, out NumSteps)) { MessageBox.Show("Неверный параметр количества шагов"); return false; }
            if (!Double.TryParse(textBoxR.Text, out R)) { MessageBox.Show("Неверный параметр r"); return false; }
            return true;
        }

        private void CreateMethod()
        {
            if (radioButtonLookOver.Checked)
                method = new MethodLookOver(A, B, C, D, X1, X2, NumSteps, Eps);
            else if (radioButtonPiavskiy.Checked)
                method = new MethodPiavskiy(R, A, B, C, D, X1, X2, NumSteps, Eps);
            else if (radioButtonStrongin.Checked)
                method = new MethodStrongin(R, A, B, C, D, X1, X2, NumSteps, Eps);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;
            CreateMethod();
            buttonCalc.Enabled = false;
            backgroundWorker.RunWorkerAsync(method);
        }

        private void ProcessRes()
        {
            FEps = method.GetFinalEps();
            FNumSteps = method.GetFinalNumSteps();
            Points = method.GetPoints();

            labelMinF.Text = Res.y.ToString();
            labelX.Text = Res.x.ToString();
            labelNumSteps.Text = FNumSteps.ToString();
            labelEps.Text = FEps.ToString();

            ShowGraph();
            ShowStroke();
        }

        private void ShowStroke()
        {
            double[] x = new double[Points.Count], y = new double[Points.Count];
            for (int i = 0; i < Points.Count; i++)
            {
                x[i] = Points[i];
                y[i] = 0;
            }

            System.Windows.Forms.DataVisualization.Charting.Series s = new System.Windows.Forms.DataVisualization.Charting.Series();
            for (int i=0; i<Points.Count; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.DataPoint d = new System.Windows.Forms.DataVisualization.Charting.DataPoint(Points[i], 0);
                d.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                d.Color = Color.DarkGreen;
                s.Points.Add(d);
            }
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series.Add(s);
        }

        private void ShowGraph()
        {

            int n = 1000;
            double[] x = new double[n], y = new double[n];
            for (int i=0; i < n; i++)
            {
                x[i] = i * (X2 - X1) / n + X1;
                y[i] = A * Math.Sin(B * x[i]) + C * Math.Cos(D * x[i]);
            }

            System.Windows.Forms.DataVisualization.Charting.Series s = new System.Windows.Forms.DataVisualization.Charting.Series();
            s.Points.DataBindXY(x,y);
            s.ChartType= System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart1.Series.Clear();
            chart1.Series.Add(s);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.###";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.###";
            chart1.ChartAreas[0].AxisX.Minimum = X1;
            chart1.ChartAreas[0].AxisX.Maximum = X2;
            chart1.ChartAreas[0].AxisY.Minimum = y.Min();
            chart1.ChartAreas[0].AxisY.Maximum = y.Max();
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "f(x)";

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Res = ((Method)e.Argument).FindMin();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCalc.Enabled = true;
            ProcessRes();
        }

        private void radioButtonLookOver_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEps.Enabled = true;
            textBoxNumSteps.Enabled = true;
            textBoxR.Enabled = false;
        }

        private void radioButtonPiavskiy_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEps.Enabled = true;
            textBoxNumSteps.Enabled = true;
            textBoxR.Enabled = true;
        }

        private void radioButtonStrongin_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEps.Enabled = true;
            textBoxNumSteps.Enabled = true;
            textBoxR.Enabled = true;
        }
    }
}

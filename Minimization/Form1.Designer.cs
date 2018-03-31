namespace Minimization
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelResults = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelEps = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelNumSteps = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMinF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxEps = new System.Windows.Forms.TextBox();
            this.textBoxNumSteps = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPiavskiy = new System.Windows.Forms.RadioButton();
            this.radioButtonStrongin = new System.Windows.Forms.RadioButton();
            this.radioButtonLookOver = new System.Windows.Forms.RadioButton();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxResults.SuspendLayout();
            this.panelData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.chart1);
            this.panelResults.Controls.Add(this.groupBoxResults);
            this.panelResults.Location = new System.Drawing.Point(298, 9);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(524, 512);
            this.panelResults.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(7, 99);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(512, 406);
            this.chart1.TabIndex = 1;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelEps);
            this.groupBoxResults.Controls.Add(this.label13);
            this.groupBoxResults.Controls.Add(this.labelNumSteps);
            this.groupBoxResults.Controls.Add(this.label4);
            this.groupBoxResults.Controls.Add(this.labelX);
            this.groupBoxResults.Controls.Add(this.label3);
            this.groupBoxResults.Controls.Add(this.labelMinF);
            this.groupBoxResults.Controls.Add(this.label1);
            this.groupBoxResults.Location = new System.Drawing.Point(7, 5);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(512, 82);
            this.groupBoxResults.TabIndex = 0;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Результаты";
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Location = new System.Drawing.Point(299, 50);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(10, 13);
            this.labelEps.TabIndex = 7;
            this.labelEps.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Точность:";
            // 
            // labelNumSteps
            // 
            this.labelNumSteps.AutoSize = true;
            this.labelNumSteps.Location = new System.Drawing.Point(382, 26);
            this.labelNumSteps.Name = "labelNumSteps";
            this.labelNumSteps.Size = new System.Drawing.Size(10, 13);
            this.labelNumSteps.TabIndex = 5;
            this.labelNumSteps.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Общее количество шагов:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(59, 50);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(10, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "x*=";
            // 
            // labelMinF
            // 
            this.labelMinF.AutoSize = true;
            this.labelMinF.Location = new System.Drawing.Point(59, 26);
            this.labelMinF.Name = "labelMinF";
            this.labelMinF.Size = new System.Drawing.Size(10, 13);
            this.labelMinF.TabIndex = 1;
            this.labelMinF.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fi*=";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxX2);
            this.panelData.Controls.Add(this.label12);
            this.panelData.Controls.Add(this.textBoxX1);
            this.panelData.Controls.Add(this.label14);
            this.panelData.Controls.Add(this.buttonCalc);
            this.panelData.Controls.Add(this.textBoxR);
            this.panelData.Controls.Add(this.textBoxEps);
            this.panelData.Controls.Add(this.textBoxNumSteps);
            this.panelData.Controls.Add(this.label11);
            this.panelData.Controls.Add(this.label10);
            this.panelData.Controls.Add(this.label9);
            this.panelData.Controls.Add(this.groupBox1);
            this.panelData.Controls.Add(this.textBoxD);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.textBoxC);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.textBoxB);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.textBoxA);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Location = new System.Drawing.Point(12, 9);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(280, 512);
            this.panelData.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(172, 157);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(79, 20);
            this.textBoxX2.TabIndex = 16;
            this.textBoxX2.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "x2=";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(51, 157);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(79, 20);
            this.textBoxX1.TabIndex = 14;
            this.textBoxX1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "x1=";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(28, 450);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(205, 41);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(136, 390);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(93, 20);
            this.textBoxR.TabIndex = 11;
            // 
            // textBoxEps
            // 
            this.textBoxEps.Location = new System.Drawing.Point(106, 360);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(93, 20);
            this.textBoxEps.TabIndex = 11;
            // 
            // textBoxNumSteps
            // 
            this.textBoxNumSteps.Location = new System.Drawing.Point(205, 332);
            this.textBoxNumSteps.Name = "textBoxNumSteps";
            this.textBoxNumSteps.Size = new System.Drawing.Size(53, 20);
            this.textBoxNumSteps.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Параметр метода (r):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Точность (eps):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Максимальное количество шагов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPiavskiy);
            this.groupBox1.Controls.Add(this.radioButtonStrongin);
            this.groupBox1.Controls.Add(this.radioButtonLookOver);
            this.groupBox1.Location = new System.Drawing.Point(20, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм";
            // 
            // radioButtonPiavskiy
            // 
            this.radioButtonPiavskiy.AutoSize = true;
            this.radioButtonPiavskiy.Location = new System.Drawing.Point(30, 46);
            this.radioButtonPiavskiy.Name = "radioButtonPiavskiy";
            this.radioButtonPiavskiy.Size = new System.Drawing.Size(115, 17);
            this.radioButtonPiavskiy.TabIndex = 2;
            this.radioButtonPiavskiy.Text = "Метод Пиявского";
            this.radioButtonPiavskiy.UseVisualStyleBackColor = true;
            this.radioButtonPiavskiy.CheckedChanged += new System.EventHandler(this.radioButtonPiavskiy_CheckedChanged);
            // 
            // radioButtonStrongin
            // 
            this.radioButtonStrongin.AutoSize = true;
            this.radioButtonStrongin.Checked = true;
            this.radioButtonStrongin.Location = new System.Drawing.Point(30, 69);
            this.radioButtonStrongin.Name = "radioButtonStrongin";
            this.radioButtonStrongin.Size = new System.Drawing.Size(113, 17);
            this.radioButtonStrongin.TabIndex = 1;
            this.radioButtonStrongin.TabStop = true;
            this.radioButtonStrongin.Text = "Метод Стронгина";
            this.radioButtonStrongin.UseVisualStyleBackColor = true;
            this.radioButtonStrongin.CheckedChanged += new System.EventHandler(this.radioButtonStrongin_CheckedChanged);
            // 
            // radioButtonLookOver
            // 
            this.radioButtonLookOver.AutoSize = true;
            this.radioButtonLookOver.Location = new System.Drawing.Point(30, 23);
            this.radioButtonLookOver.Name = "radioButtonLookOver";
            this.radioButtonLookOver.Size = new System.Drawing.Size(69, 17);
            this.radioButtonLookOver.TabIndex = 0;
            this.radioButtonLookOver.Text = "Перебор";
            this.radioButtonLookOver.UseVisualStyleBackColor = true;
            this.radioButtonLookOver.CheckedChanged += new System.EventHandler(this.radioButtonLookOver_CheckedChanged);
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(171, 112);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(79, 20);
            this.textBoxD.TabIndex = 8;
            this.textBoxD.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "d=";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(171, 82);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(79, 20);
            this.textBoxC.TabIndex = 6;
            this.textBoxC.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "c=";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(51, 112);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(79, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "b=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(51, 82);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(79, 20);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "f(x)=a*sin(bx)+c*cos(dx)\r\n            x[x1,x2]";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 526);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelResults);
            this.Name = "MainForm";
            this.Text = "Минимизация функции на отрезке";
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Panel panelData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelNumSteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMinF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxEps;
        private System.Windows.Forms.TextBox textBoxNumSteps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPiavskiy;
        private System.Windows.Forms.RadioButton radioButtonStrongin;
        private System.Windows.Forms.RadioButton radioButtonLookOver;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label14;
    }
}


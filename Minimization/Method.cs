using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minimization
{
    abstract class Method
    {
        protected double a, b, c, d, x1, x2, eps, finalEps;
        protected int numSteps, finalNumSteps;
        protected List<double> X = new List<double>();
        double xf, zf;


        public List<double> GetPoints()
        {
            return X;
        }

        public MyPoint GetRes()
        {
            return new MyPoint(xf, zf);
        }

        public double GetFinalEps()
        {
            return finalEps;
        }

        public int GetFinalNumSteps()
        {
            return finalNumSteps;
        }

        public double Fi(double x)
        {
            return a * Math.Sin(b * x) + c * Math.Cos(d * x);
        }

        abstract public double R(double xi_1, double xi);
        abstract public double GetNewX(double xt_1, double xt);

        public MyPoint FindMin()
        {
            InitializeX();
            SetRes();
            int num = 0;
            double xt_1 = x1, xt = x2,xnew = 0;
            while (xt - xt_1 > eps && num < numSteps)
            {
                num++;
                xt_1 = GetXt().x;
                xt = GetXt().y;
                xnew = GetNewX(xt_1, xt);
                X.Add(xnew);
                X.Sort();
                SetRes(xnew);
            }
            finalEps = xt - xt_1;
            finalNumSteps = num;
            return GetRes();
        }

        private void SetRes()
        {
            if (Fi(x1) > Fi(x2))
            {
                xf = x2;
                zf = Fi(x2);
            }
            else
            {
                xf = x1;
                zf = Fi(x1);
            }
        }

        private void SetRes(double xnew)
        {
            if (zf > Fi(xnew))
            {
                zf = Fi(xnew);
                xf = xnew;
            }
        }

        private void InitializeX() {
            X.Add(x1);
            X.Add(x2);
            X.Sort();
        }

        private MyPoint GetXt()
        {
            double maxR = Double.MinValue;
            double xt_1 = x1, xt = x2;
            for (int i = 1; i < X.Count; i++)
                if (R(X[i - 1], X[i]) > maxR)
                {
                    maxR = R(X[i - 1], X[i]);
                    xt_1 = X[i - 1];
                    xt = X[i];
                }
            return new MyPoint(xt_1, xt);
        }

    }
}

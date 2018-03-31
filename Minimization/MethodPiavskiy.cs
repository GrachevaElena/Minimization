using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimization
{
    class MethodPiavskiy: SmartMethod
    {
        public MethodPiavskiy(double r, double a, double b, double c, double d, double x1, double x2, int numSteps, double eps)
        {
            this.r = r;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.x1 = x1;
            this.x2 = x2;
            this.numSteps = numSteps;
            this.eps = eps;
        }

        public override double R(double xi_1, double xi)
        {
            return 0.5 * GetM() * (xi - xi_1) - (Fi(xi) + Fi(xi_1)) / 2;
        }

        public override double GetNewX(double xt_1, double xt)
        {
            return 0.5 * (xt + xt_1) - (Fi(xt) - Fi(xt_1)) / (2 * GetM());
        }

    }
}

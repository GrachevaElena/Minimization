using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimization
{
    abstract class SmartMethod: Method
    {
        protected double r;

        protected double GetM()
        {
            double M = Double.MinValue;
            for (int i = 1; i < X.Count; i++)
                M = Math.Max(M, Math.Abs((Fi(X[i]) - Fi(X[i - 1])) / (X[i] - X[i - 1])));
            return M > 0 ? r * M : 1;
        }
    }
}

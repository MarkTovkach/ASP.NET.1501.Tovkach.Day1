using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    public static class NewtonMethod
    {
        /// <summary>
        /// The method returns a value equal to the root of n-th power of the number with a specified accuracy. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <param name="eps"></param>
        /// <returns></returns>
        public static double RootOfNDegree(double x, double n, double eps)
        {
            if (n == 0) return 1;
            if (x == 1) return 1;
            double x1;
            double x0 = x / 2;
            double a = x;
            do
            {
                x1 = x0;
                x = (1 / n) * ((n - 1) * x1 + a / Math.Pow(x1,(n-1)));
                x0 = x;

            } while (Math.Abs(x0 - x1) > eps);
            return (x);
        }
    }
}

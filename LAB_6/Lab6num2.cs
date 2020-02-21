using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Lab6num2
    {
        public double[] Num2(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            double x1;
            double x2;
            var massx2 = new double[2];

            if (a == 0)
                throw new System.ArgumentException();
            if (D == 0)
            {
                var mass = new double[0];
                return mass;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                var mass = new double[] { x1 };
                return mass;
            }
            if(D>0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                massx2[0] = x1;
                massx2[1] = x2;
            }
            return massx2;
        }
    }
}

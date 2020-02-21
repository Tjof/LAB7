using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Lab6num3
    {
        public int Num3 (int n)
        {
            if (n <= 0)
                throw new System.ArgumentException();
            if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
                return 366;
            else
                return 365;
        }
    }
}

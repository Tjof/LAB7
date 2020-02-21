using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Lab6num1
    {
        public string Num1(int n)
        {
            var list = new StringBuilder(n);
            if (n > 26 || n <= 0)
                throw new System.ArgumentException();
            else
            {
                for (char i = 'A'; i < 'A' + n; i++)
                    list.Append(i);
            }
            string s = list.ToString();
            return s;
        }
    }
}

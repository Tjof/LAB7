using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Lab6num5
    {
        public int Num5(string count)
        {
            int sum = 0;
            if (Int32.Parse(count) < 0)
                throw new System.ArgumentException();
            else
            {
                for (int i = 0; i < count.Length; i++)
                {
                    sum += Convert.ToInt32(count[i].ToString());
                }
            }
            return sum;
        }
    }
}

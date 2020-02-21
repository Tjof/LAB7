using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Lab6num4
    {
        public bool Num4(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"; //Microsoft сошёл с ума... куда такую регулярку предлагать...
            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                throw new System.ArgumentException();
            }

        }
    }
}

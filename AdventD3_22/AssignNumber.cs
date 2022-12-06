using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventD3_22
{
    internal class AssignNumber
    {
        public static int assignNum (char ch)
        {
            if (ch >= 'a' && ch <= 'z') ch -= (char)('a' - 1);
            else
                if (ch >= 'A' && ch <= 'Z')
            {
                ch -= (char)('A' - 1);
                int n = ch;
                ch = (char)(n + 26);
            }
            return (int)ch;
        }
    }
}

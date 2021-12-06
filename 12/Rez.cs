using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Rez
    {
        public static int P(int a)
        {
            return  4 * a;
        }
        public static int S(int a)
        {
            return a * a;
        }
        public static int Edinica(int a)
        {
            return a % 10;
        }
        public static int Desyatki(int a)
        {
            return a / 10 % 10;
        }

    }
}

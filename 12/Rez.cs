using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Rez
    {
        public static void P(int a, out int rez)
        {
            rez = 4 * a;
        }
        public static void S(int a, out int rez)
        {
            rez = a * a;
        }
        public static void Edinica(int a, out int rez)
        {
            rez = a % 10;
        }
        public static void Desyatki(int a, out int rez)
        {
            rez = a / 10 % 10;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    internal class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

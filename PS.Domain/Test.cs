using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Test
    {
        public void fonc(int a, int b)
        {
            a++;
            b++;
            System.Console.WriteLine($"a={a},b={b}");
        }

        public void fonc2(ref int a, ref int b)
        {
            a++;
            b++;
            System.Console.WriteLine($"a={a},b={b}");
        }
    }
}

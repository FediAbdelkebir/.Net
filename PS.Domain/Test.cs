using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Test
    {
        public void MethodParValeur(int a,int b)
        {
            a++;
            b++;
          System.Console.WriteLine("A="+a,"B="+b);
        }

        public void MethodParReferance(ref int a, ref int b)
        {
            a++;
            b++;
            System.Console.WriteLine("A=" + a, "B=" + b);
        }
    }
}

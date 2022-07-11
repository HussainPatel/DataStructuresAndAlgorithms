using System;
using System.Collections.Generic;
using System.Text;

namespace III_RecursionDemo
{
    public class Iterative
    {
        public void Calculate(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine($"print k : {k}");
                n = n - 1;
            }
        }
    }
}

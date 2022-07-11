using System;
using System.Collections.Generic;
using System.Text;

namespace III_RecursionDemo
{

    public class TreeRecursion
    {
        /// <summary>
        /// when a function or a method calls itseld more than once within the same base condtion then its known as tree recusrion
        /// </summary>
        /// <param name="n"></param>
        public void CalculateTree(int n)
        {
            if (n > 0)
            {
                CalculateTree(n - 1);
                int k = n * n;
                Console.WriteLine($"print k : {k}");
                CalculateTree(n - 1);
            }
        }
    }
}

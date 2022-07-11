using System;
using System.Collections.Generic;
using System.Text;

namespace III_RecursionDemo
{
    public class HeadAndTailRecursion
    {
        public void CalculateHead(int n)
        {
            if (n > 0)
            {                
                CalculateHead(n - 1); // recursive call at start of the base condition - no other statement before the recursive call
                int k = n * n;
                Console.WriteLine($"CalculateHead k :{k}");
            }
        }

        public void CalculateTail(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine($"CalculateTail k : {k}");
                CalculateTail(n-1); // recursive call at end of the base condition - no other statement after the recursive call
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace III_RecursionDemo
{
    public class NaturalNumbers
    {
        public int CalculateSumNaturalNo(int n)
        {
            if (n == 1) return n;

            return n + CalculateSumNaturalNo(n - 1);
        }

        public int CalculateSumEvenNo(int n)
        {
            if (n == 0) return n;

            if (n % 2 == 0)
                return CalculateSumEvenNo(n - 1) + n;
            else
                return CalculateSumEvenNo(n - 1);
        }

        public int CalculateSumOddNo(int n)
        {
            if (n == 1) return n;

            if (n % 2 != 0)
                return CalculateSumOddNo(n - 1) + n;
            else
                return CalculateSumOddNo(n - 1);
        }
    }
}

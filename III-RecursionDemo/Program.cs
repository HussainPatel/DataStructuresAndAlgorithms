using System;

namespace III_RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterative t1 = new Iterative();
            //t1.Calculate(4);

            //HeadAndTailRecursion ht = new HeadAndTailRecursion();
            // ht.CalculateHead(4);
            //ht.CalculateTail(4);

            NaturalNumbers n = new NaturalNumbers();

           // Console.WriteLine($"sum of natural numbers : {n.CalculateSumNaturalNo(3)}");

            Console.WriteLine($"sum of Even natural numbers : {n.CalculateSumEvenNo(6)}");

            Console.WriteLine($"sum of Odd natural numbers : {n.CalculateSumOddNo(7)}");

            Console.Read();
        }
    }
}

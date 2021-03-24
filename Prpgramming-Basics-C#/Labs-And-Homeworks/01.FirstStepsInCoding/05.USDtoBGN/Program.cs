using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double usd = double.Parse(Console.ReadLine());

            // calcolation
            double bgn = usd * 1.79549;

            // output
            Console.WriteLine(bgn);

        }
    }
}

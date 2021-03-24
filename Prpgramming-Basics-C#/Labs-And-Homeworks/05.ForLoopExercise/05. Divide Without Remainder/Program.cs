using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            double doubleConventure = 1.0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if ( number % 2 == 0)
                {
                    p1++;
                }
                if ( number % 3 == 0)
                {
                    p2++;
                }
                if ( number % 4 == 0)
                {
                    p3++;
                }
            }
            double pp1 = doubleConventure * p1 / n * 100;
            double pp2 = doubleConventure * p2 / n * 100;
            double pp3 = doubleConventure * p3 / n * 100;

            Console.WriteLine($"{pp1:F2}%");
            Console.WriteLine($"{pp2:F2}%");
            Console.WriteLine($"{pp3:F2}%");
        }
    }
}

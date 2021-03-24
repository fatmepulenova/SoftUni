using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            double doubleConveture = 1.0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if ( number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double pp1 = doubleConveture * p1 / n * 100;
            double pp2 = doubleConveture * p2 / n * 100;
            double pp3 = doubleConveture * p3 / n * 100;
            double pp4 = doubleConveture * p4 / n * 100;
            double pp5 = doubleConveture * p5 / n * 100;

            Console.WriteLine($"{pp1:F2}%");
            Console.WriteLine($"{pp2:F2}%");
            Console.WriteLine($"{pp3:F2}%");
            Console.WriteLine($"{pp4:F2}%");
            Console.WriteLine($"{pp5:F2}%");
        }

    }
}

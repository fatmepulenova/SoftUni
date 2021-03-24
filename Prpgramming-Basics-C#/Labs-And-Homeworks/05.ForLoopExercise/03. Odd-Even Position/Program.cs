using System;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                    if (inputNumber < evenMin)
                    {
                        evenMin = inputNumber;
                    }
                    if (inputNumber > evenMax)
                    {
                        evenMax = inputNumber;
                    }
                }
                else
                {
                    oddSum += inputNumber;
                    if (inputNumber < oddMin)
                    {
                        oddMin = inputNumber;
                    }
                    if (inputNumber > oddMax)
                    {
                        oddMax = inputNumber;
                    }
                }
                
            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }


        }
    }
}

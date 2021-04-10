using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumOfPrime = 0;
            int sumOfNoPrime = 0;
            while (command != "stop")
            {
                int inputNum = int.Parse(command);
                int countForPrimeNum = 0;

                if (inputNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                        countForPrimeNum++;
                        break;
                    }
                }
                if (inputNum != 1 && countForPrimeNum == 0)
                {
                    sumOfPrime += inputNum;
                }
                else
                {
                    sumOfNoPrime += inputNum;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNoPrime}");
        }
    }
    
}

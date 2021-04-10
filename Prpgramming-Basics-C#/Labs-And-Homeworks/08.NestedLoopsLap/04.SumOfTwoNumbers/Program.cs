using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int countForCombination = 0;
            bool flag = false;
            for (int i = start; i <= stop; i++)
            {

                for (int j = start; j <= stop; j++)
                {
                    countForCombination++;
                    int currentSum = i + j;
                    if (currentSum == magic)
                    {
                        Console.WriteLine($"Combination N:{countForCombination} ({i} + {j} = {currentSum})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{countForCombination} combinations - neither equals {magic}");
            }
        }
    }
    
}

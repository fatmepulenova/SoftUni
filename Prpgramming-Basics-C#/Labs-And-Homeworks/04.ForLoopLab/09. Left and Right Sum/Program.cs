using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int number = 0;

            for (int i = 0; i < n *2; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($" Yes, sum = {leftSum}");
            }
            else
            {
                int result = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {result}");
            }
        }
    }
}

﻿using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sum = 0;

            while  (sum < inputNum)
            {
                int currentSum = int.Parse(Console.ReadLine());
                sum += currentSum;
            }
            Console.WriteLine(sum);
        }
    }
}

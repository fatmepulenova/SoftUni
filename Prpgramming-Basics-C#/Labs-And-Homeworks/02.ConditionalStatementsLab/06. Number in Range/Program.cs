﻿using System;

namespace _06._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int num = int.Parse(Console.ReadLine());
            //if else check
            if (num >= -100 && num != 0 && num <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

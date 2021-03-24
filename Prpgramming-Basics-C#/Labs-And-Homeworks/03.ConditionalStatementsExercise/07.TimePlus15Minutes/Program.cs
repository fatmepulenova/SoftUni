﻿using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        { 
            //input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //calculation
            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hour += 1;
            }
            if (hour >=24)
            {
                hour = 0;
            }
            //output
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}

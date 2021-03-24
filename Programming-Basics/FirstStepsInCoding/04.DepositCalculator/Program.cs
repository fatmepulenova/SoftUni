using System;
using System.Diagnostics.CodeAnalysis;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double yaersInterest = double.Parse(Console.ReadLine());
            // calcolation
            double interest = (deposit * yaersInterest) / 100;
            double interestPerMonth = interest / 12;
            double totalSum = deposit + term * interestPerMonth; 

            // output
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

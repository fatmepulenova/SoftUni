using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int age = int.Parse(Console.ReadLine());
            double priceForWachingmachine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;
            int temp = 10;
            //logic
            for (int i = 1; i <= age; i++)
            {
                if ( i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    savedMoney += temp;
                    temp += 10;
                }
            }
            savedMoney -= age / 2;

            savedMoney += toysCount * pricePerToy;

            double leftMoney =Math.Abs(savedMoney - priceForWachingmachine);

            if (savedMoney >= priceForWachingmachine)
            {
                Console.WriteLine($"Yes! {leftMoney: F2}");
            }
            else
            {
                Console.WriteLine($"No! {leftMoney:F2}");
            }
        }
    }
}

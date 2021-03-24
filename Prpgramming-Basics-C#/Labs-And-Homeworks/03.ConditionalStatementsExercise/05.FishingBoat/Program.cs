
using System;
using System.Xml.Schema;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int spring = 3000;
            const int summerAndAutumn = 4200;
            const int winter = 2600;
            //input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFisherman = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            //chek
            switch (season)
            {
                case "Spring":
                    totalPrice = spring;
                    break;
                case "Summer":
                    totalPrice = summerAndAutumn;
                    break;
                case "Autumn":
                    totalPrice = summerAndAutumn;
                    break;
                case "Winter":
                    totalPrice = winter;
                    break;
            }
            if (numOfFisherman <= 6)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (numOfFisherman >= 7 && numOfFisherman <= 11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (numOfFisherman % 2 == 0 && season != "Autumn")
            {
                totalPrice -= totalPrice * 0.05;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }

    }
}

using System;
using System.Buffers;

namespace _03._New_House
{
    class Program
    { 
        static double rosePrice = 5;
        static double dahliasPrice = 3.80;
        static double tulipsPrice = 2.80;
        static double narcissusPrice = 3;
        static double gladiolusPrice = 2.50;

        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (flowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * rosePrice * 0.10;
                }
                totalPrice += numberOfFlowers * rosePrice;
            }
            else if (flowers == "Dahlias")
            { 
                if (numberOfFlowers > 90)
                {
                    totalPrice -= numberOfFlowers * dahliasPrice * 0.15;
                }
                totalPrice += numberOfFlowers * dahliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * tulipsPrice * 0.15;
                }
                totalPrice += numberOfFlowers * tulipsPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    totalPrice += numberOfFlowers * narcissusPrice * 0.15;
                }
                totalPrice += numberOfFlowers * narcissusPrice;
            }
            else if (flowers== "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    totalPrice += numberOfFlowers * gladiolusPrice * 0.20;
                }
                totalPrice += numberOfFlowers * gladiolusPrice;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
        }

    }
}


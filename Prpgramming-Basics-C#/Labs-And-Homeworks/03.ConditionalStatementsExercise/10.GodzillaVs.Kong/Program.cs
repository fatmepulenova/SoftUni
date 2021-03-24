using System;

namespace _06._Godzilla_vs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {   // input
            double budjet = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceForClothesForOneStatist = double.Parse(Console.ReadLine());
            // calculation
            double priceForDecor = (budjet *0.10);
            if (statist > 150)
            {
                priceForClothesForOneStatist *= 0.9;
            }

            double priceForClothes = statist * priceForClothesForOneStatist;
            double totalSum = (priceForClothes + priceForDecor);
           
            // output
            if (totalSum <= budjet)
            {
                double remainingAmout = budjet - totalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingAmout:f2} leva left."); 
            }
            else
            {
                double needMoney = totalSum - budjet;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
                
            }

        }

    }
}

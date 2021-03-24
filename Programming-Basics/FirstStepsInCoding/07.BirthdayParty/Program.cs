using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            
            double rent = double.Parse(Console.ReadLine());

            //calculation
            double priceOfCake = rent * 0.2;
            double priceOfDrink = priceOfCake - (0.45*priceOfCake);
            double priceOfAnimator = rent / 3;
            double totalAmount = rent + priceOfCake + priceOfDrink + priceOfAnimator;

            // output
            Console.WriteLine(totalAmount); 

        }
    }
}

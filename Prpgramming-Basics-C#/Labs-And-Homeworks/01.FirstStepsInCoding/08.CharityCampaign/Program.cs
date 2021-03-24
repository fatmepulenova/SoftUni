using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numDays = int.Parse(Console.ReadLine());
            int numConfecioner = int.Parse(Console.ReadLine());
            int numCake = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancake = int.Parse(Console.ReadLine());

            //calcolation
           
            double cake = 45 * numCake;
            double waffles = 5.80 * numWaffles;
            double pancake = 3.2 * numPancake;
            double priceOfDay = (cake + waffles + pancake) * numConfecioner;
            double totalAmount = priceOfDay * numDays;
            double netAmount = totalAmount - (totalAmount / 8);

            // output
            Console.WriteLine(netAmount); 




        }
    }
}

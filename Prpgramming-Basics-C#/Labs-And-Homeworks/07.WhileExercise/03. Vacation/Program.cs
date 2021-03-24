using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCouner = 0;

            while (avaliableMoney < neededMoney)
            {
                daysCounter++;
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    spendingCouner++;
                    if (spendingCouner == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCounter}");
                        break;
                    }
                    avaliableMoney -= money;
                    if (avaliableMoney < 0)
                    {
                        avaliableMoney = 0;
                    }
                }
                else if (input == "save")
                {
                    spendingCouner = 0;
                    avaliableMoney += money;
                }
            }
            if (avaliableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
           
        }
    }
}
 
using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            double sum = 0;
            
            while (true)
            {
                 double inputMoney = double.Parse(inputNum);
                
                
                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                if (inputNum == "NoMoreMoney")
                {
                    Console.WriteLine($"Total:{sum:F2}");
                }
                
            }
            sum += inputNum;
            Console.WriteLine($"Increase:{sum}");
        }
    }
}

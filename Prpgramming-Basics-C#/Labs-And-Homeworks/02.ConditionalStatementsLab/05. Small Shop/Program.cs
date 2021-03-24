using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //град / продукт  coffe   water	  beer	  sweets  peanuts
            //Sofia           0.50    0.80    1.20    1.45    1.60
            //Plovdiv         0.40    0.70    1.15    1.30    1.50
            //Varna           0.45    0.70    1.10    1.35    1.55

            // 1. Read input 
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity =double.Parse(Console.ReadLine());

            // 2. create a variable
            double price = 0;

            // 3. switch - case  check
            switch (town)
            {
                case "Sofia":
                    
                    switch (product)
                    { //Sofia           0.50    0.80    1.20    1.45    1.60
                        case "coffee":
                            price = 0.50;
                                break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;
                        case "sweets":
                            price = 1.45;
                            break;
                        case "peanuts":
                            price = 1.60;
                            break;
                    }

                    break;
                case "Plovdiv":
                    switch (product)
                    {// 0.40    0.70    1.15    1.30    1.50
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;
                        case "sweets":
                            price = 1.30;
                            break;
                        case "peanuts":
                            price = 1.50;
                            break;


                    }
                    break;
                case "Varna":
                    switch (product)
                    {//Varna           0.45    0.70    1.10    1.35    1.55
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;
                        case "sweets":
                            price = 1.35;
                            break;
                        case "peanuts":
                            price = 1.55;
                            break;
                    }
                    break;
            }

            // 4. Write output
            Console.WriteLine(quantity * price);

        }
    }
}

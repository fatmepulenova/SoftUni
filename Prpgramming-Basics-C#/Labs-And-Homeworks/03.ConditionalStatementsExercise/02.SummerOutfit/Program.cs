using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (input == "Morning")
            {
                if (degrees <= 10 || degrees<= 18)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (degrees > 18 && degrees<= 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
            }
            else if (input == "Afternoon")
                {
                    if (degrees <= 10 || degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                    }
                }
                else
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
        }
    }
}

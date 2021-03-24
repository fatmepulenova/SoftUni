using System;

namespace _04._Personal_Titles
{
    class Program
    {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
       
            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age<16)
                {
                    Console.WriteLine("Miss");
                }
            }
            else if (gender =="m" )
            {
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }

            }
        }
    }
}

using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main()
        {
            double inches = Double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine($"{centimeters:f2}");

        }
    }
}

using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {  
            //input
            double conventNum = double.Parse(Console.ReadLine());
            string inputUnit = (Console.ReadLine());
            string outUnit = (Console.ReadLine());
            //calculation
            if (inputUnit == "mm" && outUnit == "m")
            {
                conventNum /= 1000;
            }
            else if (inputUnit == "m" && outUnit == "mm")
            {
                conventNum *= 1000;
            }
            else if (inputUnit == "mm" && outUnit == "cm")
            {
                conventNum /= 10;
            }
            else if (inputUnit == "cm" && outUnit == "mm")
                        {
                conventNum *= 10;
            }
            else if (inputUnit == "cm" && outUnit == "m")
            {
                conventNum /= 100; 
            }
            else if (inputUnit == "m" && outUnit == "cm")
            {
                conventNum *= 100;
            }
                //output
                Console.WriteLine($"{conventNum:f3}");
        }
    }
}

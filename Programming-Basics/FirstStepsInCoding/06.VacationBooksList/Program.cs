using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numStr = int.Parse(Console.ReadLine());
            double strOneH= double.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            //calculation
            double totalIimeForBook = numStr / strOneH;
            double haursADay = totalIimeForBook / numDays;

            // output
            Console.WriteLine(haursADay); 

        }
    }
}

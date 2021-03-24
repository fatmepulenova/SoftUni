using System;

namespace _9._Volleyball
{
    class Program
    { 
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendInSofia = 48 - weekends;
            double weekendInSofiaForPlay = weekendInSofia * 3.0 / 4.0;
            double holidayInSofia = holidays * 2.0 / 3.0;

            double plays = weekendInSofia + weekendInSofiaForPlay + holidayInSofia;

            if (year == "leap")
            {
                plays *= 1.15;
                Console.WriteLine($"{Math.Floor(plays)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(plays)}");
            }
        }
    }
}

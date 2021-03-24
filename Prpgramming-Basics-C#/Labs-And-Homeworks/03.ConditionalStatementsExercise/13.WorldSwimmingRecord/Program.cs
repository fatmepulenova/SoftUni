using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double recordInsec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForSeconds = double.Parse(Console.ReadLine());
            //calculation
            double distanceInSeconds = distanceInMeters * timeForSeconds;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double finalTime = distanceInSeconds + delay;
            //output
            if ( finalTime < recordInsec )
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
               
            }
            else
            {
                double neededTime = finalTime - recordInsec;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
        }

    }
}

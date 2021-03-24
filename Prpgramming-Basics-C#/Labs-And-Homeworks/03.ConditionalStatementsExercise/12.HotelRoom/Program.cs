using System;

namespace _07._HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctoberStudio = 50;
            const double mayAndOctoberApartament = 65;
            const double juneAndSeptemberStudio = 75.20;
            const double juneAndSetemberApartament = 68.70;
            const double julyAndAugustStudio = 76;
            const double julyAndAugustApartament = 77;

            string month = Console.ReadLine();
            int numNight = int.Parse(Console.ReadLine());
            double totalPriceStudio = 0;
            double totalPriceApartament = 0;

            switch (month)
            {
                case "May":
                case "October":
                    totalPriceStudio = mayAndOctoberStudio * numNight;
                    totalPriceApartament = mayAndOctoberApartament * numNight;
                    if (numNight > 7 && numNight < 14)
                    {
                        totalPriceStudio -= mayAndOctoberStudio * 0.05;
                    }
                    else if (numNight > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.30;
                    }
                    break;
                case "June":
                case "September":
                    totalPriceStudio = juneAndSeptemberStudio * numNight;
                    totalPriceApartament = juneAndSetemberApartament * numNight;
                    if (numNight > 14)
                    {
                        totalPriceStudio -= juneAndSeptemberStudio * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    totalPriceStudio = julyAndAugustStudio * numNight;
                    totalPriceApartament = julyAndAugustApartament * numNight;
                    break;
            }
            if (numNight > 14)
            {
                totalPriceApartament -= totalPriceApartament * 0.10;
            }
           
            Console.WriteLine($"Apartment: {totalPriceApartament:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
           
        }
          
    }
}

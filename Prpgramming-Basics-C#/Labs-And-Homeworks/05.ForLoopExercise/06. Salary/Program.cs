using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            const int fineForFacebook = 150;
            const int fineForInstagram = 100;
            const int fineForReddit = 50;

            for (int i = 0; i <=nTabs; i++)
            {

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string websait = Console.ReadLine();

                if (websait == "Facebook")
                {
                    salary -= fineForFacebook;
                }
                else if (websait == "Instagram")
                {
                    salary -= fineForInstagram;
                }
                else if (websait == "Reddit")
                {
                    salary -= fineForReddit;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        } 
    }
}

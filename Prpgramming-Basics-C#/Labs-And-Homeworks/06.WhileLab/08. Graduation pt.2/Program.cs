using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalSum = 0;
            int currentGrade = 1;
            int countOfRepeatedClass = 0;

            while (currentGrade <= 12)
            {
                if(countOfRepeatedClass == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                    Environment.Exit(0);
                }
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4 )
                {
                    countOfRepeatedClass++;

                    continue;
                }
                totalSum += grade;
                currentGrade++;
            }
            double avarageGrade = totalSum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:F2}");
        }
    }
}

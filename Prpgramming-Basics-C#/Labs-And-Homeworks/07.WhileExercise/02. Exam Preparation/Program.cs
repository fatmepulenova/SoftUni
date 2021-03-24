using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfbadGrade = int.Parse(Console.ReadLine());
            
            
            int countOfBadGrade = 0;
            int countOfProblem = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (countOfBadGrade < numOfbadGrade)
            {
                string nameOfProblem = Console.ReadLine();
                if ("Enough" == nameOfProblem)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    countOfBadGrade++;
                }
                gradeSum += grade;
                countOfProblem++;
                lastProblem = nameOfProblem;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {countOfBadGrade} poor grades.");
            }
            else
            {
                double avarageGrade = gradeSum / countOfProblem;
                Console.WriteLine($"Average score: {avarageGrade:F2}");
                Console.WriteLine($"Number of problems: {countOfProblem}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}

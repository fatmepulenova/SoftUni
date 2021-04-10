using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJury = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int gradeCount = 0;
            double sumForAll = 0;

            while (name != "Finish")
            {
                double gradeSum = 0;
                for (int i = 0; i < numOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    sumForAll += grade;
                    gradeCount++;
                }
                double averageSum = gradeSum / numOfJury;
                Console.WriteLine($"{name} - {averageSum:F2}.");
                name = Console.ReadLine();

            }
            double averagAllGrades = sumForAll / gradeCount;
            Console.WriteLine($"Student's final assessment is {averagAllGrades:F2}.");
        }
    }
}

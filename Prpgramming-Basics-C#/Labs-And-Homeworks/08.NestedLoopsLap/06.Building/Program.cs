using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFloor = int.Parse(Console.ReadLine());
            int numOfRoom = int.Parse(Console.ReadLine());

            for (int k = 0; k < numOfRoom; k++)
            {
                Console.Write($"L{numOfFloor}{k} ");
            }
            Console.WriteLine();

            for (int i = numOfFloor - 1; i >= 1; i--)
            {
                for (int j = 0; j < numOfRoom; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

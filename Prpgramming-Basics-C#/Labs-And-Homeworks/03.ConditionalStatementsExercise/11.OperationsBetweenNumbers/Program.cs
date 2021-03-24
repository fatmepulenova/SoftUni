using System;

namespace _06._OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            string kind = "";
            double totalSum = 0;


            if (N1 == 0)
            {
                Console.WriteLine($"Cannot divide {N2} by zero");
                
            }
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");

            }

            if (operation == "+")
            {
                totalSum = N1 + N2;
                if (totalSum % 2 == 0)
                {
                    kind = "even";
                }
                else
                {
                    kind = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {totalSum} - {kind}");
            }
            if (operation == "-")
            {
                totalSum = N1 - N2;
                if (totalSum % 2 == 0)
                {
                    kind = "even";
                }
                else
                {
                    kind = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {totalSum} - {kind}");
            }
            if (operation == "*")
            {
                totalSum = N1 * N2;
                if (totalSum % 2 == 0)
                {
                    kind = "even";
                }
                else
                {
                    kind = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {totalSum} - {kind}");
            }
            if (operation == "/" && N1 != 0 && N2 != 0)
            {
                totalSum = (N1 * 1.0) / (N2 * 1.0);
                Console.WriteLine($"{N1} / {N2} = {totalSum:F2}");
            }
            if (operation == "%" && N1 != 0 && N2 != 0)
            {
                totalSum = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {totalSum}");
            }
           
        }
    }
}

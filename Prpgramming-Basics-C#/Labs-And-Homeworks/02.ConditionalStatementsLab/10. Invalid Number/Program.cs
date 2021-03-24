using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = (num >= 100) && (num <= 200) || (num == 0);
            if (!isvalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

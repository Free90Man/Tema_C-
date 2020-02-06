using System;

namespace Exercitiul7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number you what to now if it is odd or even, then press ENTER");
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Input number " + a + " is an even.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Input number " + a + " is an odd.");
            }

        }
    }
}

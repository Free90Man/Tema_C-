using System;

namespace Exercitiul5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number from 1 to 12, then press ENTER. ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            if (a < 1 || a > 12)
            {
                Console.WriteLine("Number is not valid");
                Console.WriteLine("Please input a number from 1 to 12: ");
                a = int.Parse(Console.ReadLine());
            }
            else
            {
                for (int i = 1; i < a; i++)
                {
                    b = b * i;
                }
                Console.WriteLine("Input no " + a + " factorial is: " + b);
            }
        }
    }
}

using System;

namespace Exercitiul6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To calculate the minum value from 3 numbers");
            Console.WriteLine("Input the numbers one by one");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a < b && a < c)
                   Console.WriteLine(" The minimum is the 1st number = " + a + ".");
            else if (b < a && b < c)
                    Console.WriteLine(" The minimum is the 2nd number = " + b + ".");
                else
                    Console.WriteLine(" The minimum is the 3rd number = " + c + ".");
        }
    }
}

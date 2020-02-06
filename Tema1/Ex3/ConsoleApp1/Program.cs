using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;                  //a=3;
            if (++a < 4)                // condition incremented a = 4 < 4 FALSE so program will not go further
                if (a++ < 4)            // n/a
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);
        }
    }
}

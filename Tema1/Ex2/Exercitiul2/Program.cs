using System;

namespace Exercitiul2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 2.95;
            int i = 4;
            Console.WriteLine();
            Console.WriteLine(++d > i ? d : i); 
        }
    }
}
/* display 4 because: increments d +1 ( d= 3.95) and compaire to i (4), if d is smaller then i will display i;*/ 

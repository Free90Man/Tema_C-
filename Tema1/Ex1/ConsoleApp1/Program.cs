using System;

namespace ConsoleApp1
{
    public class Asignare
    {
        public static void Main(string[] args)
        {
            int a = 3;            // initiating value for integer a with 3;
            int b = (a = 2) * a;  // int b at thispoint is 2*2=4, because a new value is 2;
            int c = b * (b = 5);  // int c is old b with 2 * 5 = 10, new value for b;
            Console.WriteLine("a= " + a + ", b= " + b + ", c= " + c); // a=2, b=5, c=20;
        }
    }
}

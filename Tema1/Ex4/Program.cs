using System;

namespace Exercitiul4
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for(int i = 1; i < 10; i++)
            {
                suma = suma + i;                    // LOOP: for every i from 1 to 9, suma will add to each value 0+1=1, 1+2=2, 2+2=3 ...  
            }                                       // last one is 36 + 9 ( i<10) ;
            Console.WriteLine("Suma este: " + suma); // =45;
        }
    }
}

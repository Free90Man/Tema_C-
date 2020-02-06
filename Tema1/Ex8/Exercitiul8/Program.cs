using System;

namespace Exercitiul8
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please input a number from 1 to 7 and and press ENTER");
			switch (Console.ReadLine())
			{
				case "1":
					Console.WriteLine();
					Console.WriteLine(" Monday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "2":
					Console.WriteLine();
					Console.WriteLine(" Tuesday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "3":
					Console.WriteLine();
					Console.WriteLine(" Wednesday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "4":
					Console.WriteLine();
					Console.WriteLine(" Thursday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
					
				case "5":
					Console.WriteLine();
					Console.WriteLine(" Friday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "6":
					Console.WriteLine();
					Console.WriteLine(" Saturday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "7":
					Console.WriteLine();
					Console.WriteLine(" Sunday");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
				case "0":
					break;
				default:
					Console.WriteLine();
					Console.WriteLine(" Invalid: please select from 1 to 7");
					Console.WriteLine();
					//Console.WriteLine("Press any key to continue or press 0 for exit.");
					break;
					
			}
		}
    }
}

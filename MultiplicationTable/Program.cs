using System;
using System.Threading;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable initialisation, applicaion loop set and welcome message.
            int n;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Multiplication Table");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Please enter the number you wish to see a table for: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                n = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Initialising table...");
                Thread.Sleep(2000);

                //For loop to iterate over 1 through 10 and output result of variable n.
                for (int x = 1; x <= 10; x++)
                {
                    Console.WriteLine($"{x} x {n} = {n * x}");
                    Thread.Sleep(500);
                }

                //End of application with the option to run again.
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Would you like to run this application again - y or n: ");
                string input = Console.ReadLine();
                if (input != "y")
                {
                    Console.WriteLine("\nThank you for using the Multiplication Table!");
                    break;
                }
            }
        }
    }
}
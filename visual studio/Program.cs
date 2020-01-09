using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Cosole Calculator App");


            while (true)
            {
                Console.Write("Enter your first number: ");
                decimal x = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter your second number: ");
                decimal y = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("/nEnter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("");

                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        Console.WriteLine("/nAnswer:");
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine("/nAnswer:");
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine("/nAnswer:");
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        Console.WriteLine("/nAnswer:");
                        Console.WriteLine(x / y);
                        break;
                }

                Console.WriteLine("\nPress any key to restart...\n");
                Console.ReadKey();
            }
        }
    }
}
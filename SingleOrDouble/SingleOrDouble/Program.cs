using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to this application.");
            Console.WriteLine();
            Console.Write("Enter the number you want to check: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                SingleOrDouble(number);
                Console.WriteLine();
                Console.WriteLine("Programmer by hakanberkeicellioglu");
                Console.WriteLine();
                Console.WriteLine("[1] Return to menu");
                Console.WriteLine("[2] Exit");
                Console.WriteLine();
                Console.WriteLine("Which action do you want to perform?");
                try
                {
                    int process = Convert.ToInt32(Console.ReadLine());
                    if(process == 1)
                    {
                        Console.Clear();
                        Main(args);
                    }
                    else if(process == 2)
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    Console.WriteLine();
                    Main(args);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine();
                Main(args);
            }
            Console.ReadLine();
        }
        public static void SingleOrDouble(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(number + " is zero.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(number + " is double.");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine(number + " is single.");
            }
        }
    }
}

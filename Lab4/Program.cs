using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factorial calculator!");

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                int input = int.Parse(Console.ReadLine());

                //Verify input
                while (input < 0 || input >= 10)
                {
                    Console.WriteLine("Invalid input! Please enter an integer that's greater than 0 but less than 10:");
                    input = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("The factorial of " + input + " is " + GetFactorial(input) + ".");

                //Continue program?
                run = Continue();
            }
        }

        public static int GetFactorial(int num)
        {
            int factorial = num;
            for (int i = 1; i < num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


        //Continue program?
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n):");
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input == "n")
            {
                Console.WriteLine("Goodbye.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}

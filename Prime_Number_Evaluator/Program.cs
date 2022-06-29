using System;

namespace Prime_Numbers
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter number to check: ");
            int number;
            // Store number as int32
            number = Convert.ToInt32(Console.ReadLine());
            // Establish variable to determine number of divisors
            int divisors = 0;

            /*  
            Prime numbers are divisible by themselves and one. Otherwise, not Prime.
            Check via for-loop, each iteration checking for divisibility, and incrementing afterwards
            until number entered is reached. Exclude zero as option is not viable/Prime definition 
            */

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The number is a Prime number");
            }
            else
            {
                Console.WriteLine("The number is not a Prime number");
            }
            Console.ReadLine();
        }
    }
}

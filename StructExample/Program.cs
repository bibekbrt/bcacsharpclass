using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeDetails objemp;
            objemp.EmployeeId = 10;


            showFibno();
        }


        public static void showFibno()
        {
            int n = 10; // Number of terms in the Fibonacci series to generate

            Console.WriteLine($"Fibonacci Series with {n} terms:");

            // Initialize the first two Fibonacci numbers
            int a = 0, b = 1;

            // Print the first two terms separately
            Console.Write($"{a} {b} ");

            // Generate subsequent terms
            for (int i = 3; i <= n; i++)
            {
                int c = a + b; // Calculate the next Fibonacci number
                Console.Write($"{c} ");

                // Update a and b for the next iteration
                a = b;
                b = c;
            }
        }
    }
}

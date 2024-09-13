using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAndRef
{
    class Program
    {

        public int Age { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter your number:");
            //int num = int.Parse(Console.ReadLine());
            int num = Convert.ToInt16(Console.ReadLine());

            if (isPrime(num))
            {
                Console.WriteLine($"your number is prime {num}");
            }
            else
            {
                Console.WriteLine($"your number is not prime {num}");
            }

            //CheckBreakFunciton();
            //CheckPrime(15);

            int num1;

            // AddTwoNumber(out num1);
            //Console.WriteLine($"Value of num1={num1}");


            Console.ReadKey();
        }

        static void CheckBreakFunciton()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine($"Value of i is {i}");

            }


        }


        static void AddTwoNumber(out int number1)
        {
            number1 = 10;
            number1 = 10 + number1;






        }

        static void CheckPrime(int number)
        {
            bool isprime = false;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    isprime = false;

                    break;
                }
                else
                {
                    isprime = true;

                }



            }
            if (isprime == true)
            {
                Console.WriteLine("not is prime");
            }
            else
            {
                Console.WriteLine(" prime");
            }

        }


        static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //static bool isPrime(int num)
        //{
        //    if (num <= 1)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % 1 == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

    }
}

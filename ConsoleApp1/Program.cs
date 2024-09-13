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
            Console.Write("Enter the number that you want the multiplication of :");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //for(int i = number; i > 1; i--)
            //{
            //    fact = fact * i;
            //}


            for (int i = 1; i <= 10; i++)
            {
                int mul = number * i;
                Console.WriteLine($"{number} * {i} = {mul}");
            }
           
            Console.ReadKey();



        }
    }
}

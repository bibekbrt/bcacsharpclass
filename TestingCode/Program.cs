using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class Program
    {
        static int sum(int[]array, int n)
        {
            if(n<=0)
            {
                return 0;
            }
            return sum(array, n - 1) + array[n - 1];
        }

        static void Main(string[] args)
        {


            int[] arr = { 2, 356 };
            int s = sum(arr, arr.Length);
            Console.WriteLine(s);
            Console.ReadKey();
           
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public delegate int DelegateName(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int, int, int> addFunction = delegate(int num1, int num2, int num3, int num4)
            {
                int total = num1 + num2 + num3 + num4;
                return total;
            };



            Func<int, int, int, int, int> addFunction = (num1, num2, num3, num4) =>
            {
                int total = num1 + num2 + num3 + num4;
                return total;
            };

            
            Action<int, int, int, int, int> add4number = (num1, num2, num3, num4,num5) =>
             {
                 int total =num1 + num2 + num3 + num4+num5;
             };

           

        }

        public int ShowTotal(int a, int b)
        {
            return a + b;
            
        }


    }



}

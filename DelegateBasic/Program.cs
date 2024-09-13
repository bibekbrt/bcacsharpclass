using System;

namespace DelegateBasic
{
    public delegate int Calc(int num);//declaring delegate

    class Program
    {
        static int n = 50;
        public static int sub(int num)
        {
            n = n - num;
            return n;
        }
        public static int mul(int num)
        {
            n = n * num;
            return n;
        }
        public static int getnum()
        {
            return n;
        }
        static void Main(string[] args)
        {
            //int total =sub(80);


            Calc x = sub;//instantiating delegate  
            Calc y = new Calc(mul);



            x.Invoke(10);//calling method using delegate  
            Console.WriteLine("After x delegate, Number is: " + getnum());
            y.Invoke(20);
            Console.WriteLine("After y delegate, Number is: " + getnum());
            Console.WriteLine("Hello World!");
        }
    }
}

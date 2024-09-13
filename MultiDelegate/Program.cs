using System;

namespace MultiDelegate
{
    class Program
    {
        public delegate void delmethod(int x, int y);

        public class TestMultipleDelegate
        {
            public void plus_Method1(int x, int y)
            {
                Console.Write("You are in plus_Method");
                Console.WriteLine(x + y);
            }

            public void subtract_Method2(int x, int y)
            {
                Console.Write("You are in subtract_Method");
                Console.WriteLine(x - y);
            }
            public void multiply_Method3(int x, int y)
            {
                Console.Write("You are in multiply method");
                Console.WriteLine(x * y);
            }
        }
        static void Main(string[] args)
        {

            ////del(50, 10);
            ////Console.WriteLine("------------------");
            ////del = obj.subtract_Method2;
            ////del(200, 100);


            TestMultipleDelegate obj = new TestMultipleDelegate();
            delmethod del = new delmethod(obj.plus_Method1);
            del += new delmethod(obj.subtract_Method2);
            del += new delmethod(obj.multiply_Method3);

            del.Invoke(50, 10);


            Console.WriteLine("----------------------");
            Console.WriteLine();
            del -= new delmethod(obj.plus_Method1);

            del.Invoke(20, 10);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace PassDelegateAsMethod
{
    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Result: {0}", x - y);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply Result: {0}", x * y);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("****Delegate Example****");
            MathOperations m = new MathOperations();
            SampleMethod(m.Add, 10, 90);
            SampleMethod(m.Subtract, 10, 90);
            SampleMethod(m.Multiply, 10, 90);
            Console.ReadLine();
        }

        static void SampleMethod(SampleDelegate dlgt, int a, int b)
        {
            dlgt(a, b);//invoke
        }
    }
}

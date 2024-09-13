using System;

namespace FuncAndAction
{
    class Program
    {
        static int Sum(int x, int y) => x + y;

        public static int Sum1(int x, int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;


            int result = add.Invoke(10, 10);
            int result1 = add(10, 10);

            Console.WriteLine(result);
        }
    }





    class Program1
    {
        static void print (string message)
        {
            Console.WriteLine($"message is {message}");
        }
        static void printVoid()
        {
            Console.WriteLine("Without Parameter");
        }

        static void Main1(string[] args)
        {
            Action parameterless = Program1.printVoid;
            Action<string> singleParameter = Program1.print;

            parameterless.Invoke();
            singleParameter.Invoke("Hello world");
                
        }
    }
}

using System;

namespace DelegateSimple
{
    class Program
    {
        public delegate void delmethod();

        public static void display()
        {
            Console.WriteLine("Hello!");
        }

        public static void show()
        {
            Console.WriteLine("Hi!");
        }

        public void print()
        {
            Console.WriteLine("Print");
        }

        static void Main(string[] args)
        {
           
            delmethod del1 = Program.show;
            delmethod del2 = new delmethod(Program.display);
            Program obj = new Program();
            delmethod del3 = obj.print;
            del1();
            del2();
            del3();
            Console.ReadLine();

        }
    }
}

using System;

namespace GenericsDelegate
{
    delegate void Printer<Suresh>(Suresh t);

    class Program
    {
        static void Main(string[] args)
        {
            Printer<int> p = consolePrinterInt;
            p(2);
            Printer<float> pf = consolePrinterFloat;
            pf(22.3f);

            Console.ReadKey();
        }


        static void consolePrinterInt(int i)
        {
            Console.WriteLine(i);
        }

        static void consolePrinterFloat(float f)
        {
            Console.WriteLine(f);
        }
    }
}

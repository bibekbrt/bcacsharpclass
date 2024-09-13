using System;

namespace DelBasic
{
    class Program
    {

        delegate void Mydelegate();
        delegate int MyIntDelegate(int a, int b);

        delegate string delanonymous(string a, string b);

        static string ShowMyname(string a, string b)
        {
            return $"you name is {a},{b}";
        }


        static int ShowAddTwoNumber(int a, int b) => a + b;

        static string ShowYourName(string a, string b) => $"your name is {a}";




        static void ShowMessage()
        {
            Console.WriteLine("Good morning");
        }
        static int AddTwoNumber(int a, int b)
        {
            return a + b;
        }

        static int MultiplyTwoNumber(int a, int b)
        {
            return a * b;
        }

        static void MultiplyTwoNumberAction(int a, int b)
        {
            int mult = a * b;
            Console.WriteLine($"Mult of two number is {mult}");
        }



        static void Main(string[] args)
        {

            //delanonymous objan = new delanonymous(ShowMyname);
            delanonymous objan = ShowMyname;
            //string retrunstr= objan.Invoke("Ram", "Shyam");
            //string retrunstr = objan("Ram", "Shyam");



            delanonymous objano = (string a, string b) =>
             {
                 return $"your name is {a},{b}";
             };



            string retval = objan.Invoke("Ram", "Shyam");
            Console.WriteLine(retval);





            //Func<int, int,int> funcsum = MultiplyTwoNumber;
            //int total = funcsum.Invoke(100, 200);

            //Action<int, int> actobj = MultiplyTwoNumberAction;

            //actobj.Invoke(10, 20);





            Console.ReadKey();
        }
    }
}

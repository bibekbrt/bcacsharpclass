using System;
using MyLibrary;

namespace AnonymExample
{
    //class Program
    //{
    //    delegate string TestDelegation(string s);
    //    delegate void TestAnonumousMethod(int intVal);
    //    static void Main(string[] args)
    //    {

    //        TestDelegation del = new TestDelegation(TestFunction);
    //        string s =del.Invoke("Ram kumar sharma");
    //        Console.WriteLine(s);

    //        TestDelegation del1 = (paramsName) => { return paramsName; };
    //        string s1 = del.Invoke("Aadim college");
    //        Console.WriteLine(s1);

    //        TestAnonumousMethod method = delegate(int i)
    //        {
    //            Console.WriteLine($" the value of i is {i}");

    //        };
    //        method.Invoke(100);



    //        Console.ReadKey();
    //    }

    //    static string TestFunction(string s)
    //    {
    //        return s;
    //    }
    //}


    class Program
    {
        delegate string TestDelegation(string s);
        static void Main(string[] args)
        {

            try
            {
                try
                {
                    Console.Write("Enter you age :");
                    int age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("your age is {0}", age);


                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message.ToString());
                }
                finally
                {
                    Console.WriteLine("Always run");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }
            


            //MyLibrary.Class1.showYourName();
            //TestDelegation delobj = delegate (string s)
            // {
            //     return $"your name is {s}"; 
            // };
            //string rs = delobj.Invoke("hari kumar malla");

            //Console.WriteLine(rs);
            Console.ReadKey();
        }


    }

    interface Myinterface
    {
        void myMethod();
    }

    public class a : Myinterface
    {
        public void myMethod()
        {
            throw new NotImplementedException();
        }
    }
}


using MypersonalNameSpace;
using System;
using System.Collections;

namespace DotNeClass
{
   

    class Program
    {
        static void Main(string[] args)
        {
            AnotherClass obj = new AnotherClass();


            ArrayList arlist = new ArrayList();
            var arlist1 = new ArrayList(); // recommended 
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);


            //Access individual item using indexer
            var firstElement = arlist1[0]; 
            string secondElement = (string)arlist1[1];

            //using var keyword without explicit casting
            //var firstElement = arlist1[0];
            //var secondElement = arlist1[1];

            //update elements
            arlist1[0] = 2342;
            arlist1[1] = "Gopal";
            //arlist[5] = 500; //Error: Index out of range


            arlist1.Insert(1, "Second Item");

            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null,
                };

            foreach (var item in arlist1)
                Console.Write(item + ", ");



            //arlist1.Remove(null); //Removes first occurance of null
            //arlist1.RemoveAt(4); //Removes element at index 4
            //arlist1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)


            //Console.WriteLine(arlist1.Contains(300)); // true
            //Console.WriteLine(arlist1.Contains("Bill")); // true
            //Console.WriteLine(arlist1.Contains(10)); // false
            //Console.WriteLine(arlist1.Contains("Steve")); // false





            //var gobj = new GenericsExample();

            //bool isEqul = gobj.isequal<int>(10, 20);
            //bool isEqulStr = gobj.isequal<string>("Ram", "Ram");


            //Console.WriteLine($"Given value are {isEqul} str gene is {isEqulStr}");


            Console.ReadKey();
        }
        
    }
    public interface Cat
    {
       void produceSound();

    }

    public interface Dog
    {
        void eatFood();
    }

    public class Animal : Cat, Dog
    {
        public void eatFood()
        {
            Console.WriteLine("Eating some food.");
        }

        public void produceSound()
        {
            Console.WriteLine("Producing some sounds.");
        }
    }

}

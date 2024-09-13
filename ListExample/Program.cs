using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

          

                                 

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list
            cities.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };




            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);




            var numbers1 = new List<int>() { 10, 20, 30, 40, 10 };

            numbers1.Remove(10); // removes the first 10 from a list

            numbers1.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException



            var Checknumbers = new List<int>() { 10, 20, 30, 40 };
            Checknumbers.Contains(10); // returns true
            Checknumbers.Contains(11); // returns false
            Checknumbers.Contains(20); // returns true


            //var students = new List<Student>() {
            //    new Student(){ Id = 1, Name="Bill"},
            //    new Student(){ Id = 2, Name="Steve"},
            //    new Student(){ Id = 3, Name="Ram"},
            //    new Student(){ Id = 4, Name="Abdul"}
            //};


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

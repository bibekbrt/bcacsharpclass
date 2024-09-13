using System;
using System.Collections.Generic;

namespace AddClassData
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.eat();
            myDog.makeSound();
            myDog.sleep();

            

            //List<Student> stdList = new List<Student>();
            //bool anotherUser = true;

            //while (anotherUser)
            //{
            //    var std = new Student();
            //    Console.Write("Enter student Id :");
            //    std.StudentId = Convert.ToInt16(Console.ReadLine());
            //    Console.Write("Enter student Name :");
            //    std.StudentName = Console.ReadLine();
            //    Console.Write("Enter student Address :");
            //    std.StudentAddress = Console.ReadLine();
            //    stdList.Add(std);
            //    Console.WriteLine("Do you want to add another user (type Y for yes,N for No)?");
            //    string next = Console.ReadLine();
            //    anotherUser = (next == "Y");
            //}
          
            //foreach (var item in stdList)
            //{
            //    Console.WriteLine("Following are details");
            //    Console.WriteLine($" id -{item.StudentId}, name ={item.StudentName}, address={item.StudentAddress}");
            //}


            //int[] sourcearray = { 1, 2, 80, 5 };

            //int maxElement = sourcearray[0];

            //for (int i = 1; i < sourcearray.Length; i++)
            //{
            //    if(sourcearray[i]>maxElement)
            //    {
            //        maxElement = sourcearray[i];
            //    }
            //}

            //int topelement = maxElement;

            
            

            //int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            //Array.Sort(array); //sorting array  
            //Array.Reverse(array); // Reverse Sorting array value  
            //Console.WriteLine("Second Highest Value In Array " + array[1]);

            //foreach (var result in array)
            //{
            //    Console.Write(result + " "); // Array values   
            //}




            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

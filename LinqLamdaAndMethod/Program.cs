using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ Query to get even numbers
        var evenNumbers = from abc in numbers
                          where abc % 2 == 0
                          select abc;

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Using Method Syntax for the same query
        var oddNumbers = numbers.Where(n => n % 2 != 0);

        Console.WriteLine("Odd numbers:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }

        

        //Another example
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30, Email="suresh@gmail.com" },
            new Person { Name = "Bob", Age = 25 , Email="anil@gmail.com"},
            new Person { Name = "Charlie", Age = 35 , Email="shyam@gmail.com"},
            new Person { Name = "David", Age = 40 , Email="gita@gmail.com"}
        };
        //query
        var resultValue = from student in people
                          where student.Email.Contains("suresh@gmail.com")
                          select student;
        //method
        var method1 = people.Where(x => x.Email == "suresh@gmail.com");
        int totalcount = people.Count;
        var methodval = people.OrderByDescending(x => x.Age).ThenByDescending(x=>x.Name);
        

        //Person p = new Person();
        //p.Name = "suresh";
        //p.Age = 28;
        //people.Add(p);

        // LINQ Query Syntax to find people older than 30
        var olderPeople = from person in people
                          where person.Age > 30
                          select person;

        Console.WriteLine("People older than 30:");
        foreach (var person in olderPeople)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }

        // Using Method Syntax for the same query
        var youngerPeople = people.Where(p => p.Age <= 30);

        Console.WriteLine("People 30 or younger:");
        foreach (var person in youngerPeople)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }



    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}

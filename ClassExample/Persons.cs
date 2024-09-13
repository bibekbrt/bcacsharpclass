using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class Persons
    {
        private int rollNumber;
        public string StudentName;
        public string address = "Kathmandu";

        public Persons()
        {
            Console.WriteLine("From Constructor");
        }
        public Persons(int rollNumber)
        {
            this.rollNumber = rollNumber;
        }

        public Persons(int rollNumber, string StudentName)
        {
            this.rollNumber = rollNumber;
            this.StudentName = StudentName;
        }

        public void ShowPersonDeatils()
        {
            Console.WriteLine($"your name is {StudentName} " +
                $"your roll is {rollNumber}");
        }





    }
}

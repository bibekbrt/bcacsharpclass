using System;
using System.Collections.Generic;
using System.Text;

namespace AddClassData
{
    public abstract class Animal
    {
        public abstract void eat();

        public abstract void makeSound();


        public void sleep()
        {
            Console.WriteLine("animal is sleeping");
        }


    }

    public class Dog : Animal
    {

        public override void eat()
        {

            base.sleep();
            Console.WriteLine("dog is eating naresh's food");
        }

        public override void makeSound()
        {
            Console.WriteLine("dog is woff woff");
        }
    }



    public sealed class Teacher
    {
        public int TeacherId { get; set; }
    }

    public class PartTimeTeacher : Animal
    {
        public override void eat()
        {
            throw new NotImplementedException();
        }

        public override void makeSound()
        {
            throw new NotImplementedException();
        }
    }


}

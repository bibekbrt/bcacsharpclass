using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Persons objName = new Persons();
           
            objName.StudentName = "Ram";
            objName.address = "Nepal";
            objName.ShowPersonDeatils();


            Persons objPerson = new Persons(5, "Hari");

            objPerson.ShowPersonDeatils();



            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the length");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            decimal breadth = Convert.ToDecimal(Console.ReadLine());

            Area area = new Area();
            area.length = length;
            area.breadth = breadth;
            area.calculateArea();

            Area newArea = new Area(length, breadth);
            newArea.calculateArea();

            Console.ReadKey();
            
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    class Area
    {
        public decimal length;
        public decimal breadth;
        public Area(decimal length, decimal breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public Area()
        {

        }
        public void calculateArea()
        {
            decimal area = this.length * this.breadth;
            Console.WriteLine($"The area is {area}");
        }
    }
}

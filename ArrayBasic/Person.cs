using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Person
    {



        public int PersonId = 50;
        public string PersonName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }




        public Person()
        {
            
            Console.WriteLine($"persion id is {PersonId}");
        }


        public void ShowPersonName()
        {
            Console.WriteLine($"person name is {PersonName}");
        }

        static Person()
        {
        }






    }
}

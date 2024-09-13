using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQEXMP
{
    class Program
    {
        static void Main(string[] args)
        {




            //select name from student
            //where name like 'a%'

            //Linq query to array
            string[] studentName = { "Ram", "Hari", "Shyam", "Sita", "Anil" };
            var resultName = from stdName in studentName
                             where stdName.StartsWith('a')
                             select stdName;

            foreach (var item in studentName)
            {
                Console.WriteLine($"name contains a are {item}");
            }


            //LINQ query to List

            List<string> languages = new List<string>()
            {
                "C# Sharp",
                "VB.NET",
                "PHP",
                "JQUERY",
                "REACT"
            };
            //var searchQuery = from language in languages
            //                  where language.Contains("PHP")
            //                  select language;

            var searchQuery = languages.Where(s=>s.Contains("PHP"));
            foreach (var item in searchQuery)
            {
                Console.WriteLine($"Language contain PHP is {item}");

            }


            //Use of Lambda expression to LINQ

            List<int> numbersList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            List<int> evenNumber = numbersList.FindAll(x => (x % 2) == 0);
            foreach (var item in evenNumber)
            {
                Console.WriteLine($"even numbers are {item}");
            }




            List<Students> studentList = new List<Students>()
            {
                new Students{ Id=1,studentName="Hari"},
                new Students{ Id=2,studentName="Sita"},
                new Students{ Id=3,studentName="Shyam"}
            };
            var nameList = studentList.Select(x => x.studentName);
            
            foreach (var item in nameList)
            {
                Console.WriteLine($"Students name are as follows :{item}");
            }

            var sortNamelist = studentList.OrderByDescending(x => x.Id);
            foreach (var sortlistItem in sortNamelist)
            {
                Console.WriteLine($"Sort list {sortlistItem.Id},{sortlistItem.studentName}");
            }



            //where condtion
            List<string> countriesList = new List<string>()
            {
                "Nepal", "India","Bhutwan","Pakistan","Srilanaka"
            };

            var searchCountries = countriesList.Where(
                x => x.Contains("Nepal") || x.Contains("India")
                );


            //&& and
            //|| or

            foreach (var item in searchCountries)
            {
                Console.WriteLine($"Countries list {item}");
            }



            Console.ReadKey();
        }
    }


    public class Students
    {
        public int Id { get; set; }
        public string studentName { get; set; }
    }
}

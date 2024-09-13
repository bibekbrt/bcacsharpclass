using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string[,] records;
            string choice = p.addRecords();
            here:
            if(choice=="yes" ||choice=="Yes" ||choice== "YES")
            {
                choice = p.addRecords();
                
                goto here;
            }
            else
            {
                p.displayRecords();
            }
        }
        public string addRecords(){
            Console.Write("Enter the id:");
            string id = Console.ReadLine();
            Console.Write("Enter the name:");
            string name = Console.ReadLine();
            Console.Write("Enter the address:");
            string address = Console.ReadLine();
            string[] record=new string[3];
            record[0] = id;
            record[1] = name;
            record[2] = address;
            
            Console.Write("Do you want to add another item (Yes/No):");
            String choice = Console.ReadLine();
            return choice;
        }
        public void displayRecords()
        {

        }
    }
}

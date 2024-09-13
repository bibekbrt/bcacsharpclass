using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public static class StaticExamp
    {
        public static int EmployeeId { get; set; }



        
        //public StaticExamp()
        //{

        //}

        public static void ShowEmpName()
        {
            Console.WriteLine("Your name is Ram");
        }

    }


    struct EmployeeDetails
    {
        public int EmployeeId;
        public string EmployeeName { get; set; }

        //public EmployeeDetails(int EmployeeId, string EmployeeName)
        //{
        //    this.EmployeeId = EmployeeId;
        //    this.EmployeeName = EmployeeName;
        //}




    }
    
}

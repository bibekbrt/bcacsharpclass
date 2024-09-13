using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    struct MyEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        
        public MyEmployee(int Id, string EmpName)
        {
            this.EmployeeId = Id;
            this.EmployeeName = EmpName;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teachers
    {
        public virtual void teach() {
            Console.WriteLine("Teacher teach students.");
        }
    }

    class Students: Teachers
    {
        public override void teach()
        {
            Console.WriteLine("Student teach Junior Student.");
        }

        
    }
}

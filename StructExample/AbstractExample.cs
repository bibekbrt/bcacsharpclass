using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public abstract class AbstractExample
    {
        public void showName()
        {
            Console.WriteLine("");
        }
        public abstract void DisplayName();
    }

    public class DerivedClassEx : AbstractExample
    {
        
        
        public override void DisplayName()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DotNeClass
{
    public class GenericsExample
    {

        public bool isequal<T>(T a, T b)
        {
            return a.Equals(b);
        }


    }
}

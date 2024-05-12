using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.OOP
{
    public class MethodOverloading
    {
        public MethodOverloading() { }

        public int OverLoadMethod()
        {
            return 0;
        }
        
        //Ques::: If method varies only be return type
        //Ans:::  This will return error since overload varies only by return type
        //public double OverLoadMethod()
        //{
        //    return 0; 
        //}

    }
}

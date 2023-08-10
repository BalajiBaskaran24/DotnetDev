using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class Equals_EqualToOperator
    {
        //Comparison of .Equals and == operator

        public override bool Equals(object? obj)
        {
            Console.WriteLine("Invoked overloaded function");
            return this == obj ? true : false;
        }

        public static bool operator ==(Equals_EqualToOperator left, Equals_EqualToOperator right)
        {
            return false;
        }

        public static bool operator !=(Equals_EqualToOperator left, Equals_EqualToOperator right)
        {
            return false;
        }


        public static void StarterEquals()
        {
            Equals_EqualToOperator sample = null;
            if (sample == null)
            {
                Console.WriteLine("== operator returns null correctly");
            }
            else
            {
                Console.WriteLine("== operator fails to return null");
            }

            if (object.Equals(sample, null))
            {
                Console.WriteLine(".Equals operator returns null correctly");
            }
            else
            {
                Console.WriteLine(".Equals operator fails to return null");
            }

            sample = new Equals_EqualToOperator();
            if (sample.Equals(null)) { }

        }

    }
}

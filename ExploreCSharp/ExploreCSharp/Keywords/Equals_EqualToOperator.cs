using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    /// <summary>
    /// Class that compares the null check using == operator and .Equals or is null method usage
    /// KEYWORDS COVERED: is, not, and, or
    /// is: Check whether runtime type of expression result is compatible with given type
    /// Problem statement: Using == for null check can go wrong 
    /// Because: This operator can be overridden, user defined logic can happen 
    /// Conclusion: Use Equals ReferenceEquals() / is / is not 
    /// </summary>
    public class Equals_EqualToOperator
    {
        /// <summary>
        /// Override Equals method. Takes object as input parameter
        /// Not recommended for null check, since the calling object call be null
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            Console.WriteLine("Invoked overloaded function");
            return this == obj ? true : false;
        }

        /// <summary>
        /// Operator overloading of equals function
        /// Can pass any data model as input parameter, and the behavior will be 
        /// applicable only for this data model
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
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
            //KEYWORDS COVERED: is, and, or
            static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

            Equals_EqualToOperator sample = null;

            //---------------Will always provide right output---------------
            if (sample is null)//Returns true for null
            {

            }

            if (sample is not null)//Returns true for not null
            {

            }
            //---------------------------------------------------------------

            //---------------If overridden, behavior can be altered---------------
            if (sample == null)
            {
                Console.WriteLine("== operator returns null correctly");
            }
            else
            {
                Console.WriteLine("== operator fails to return null");
            }
            //--------------------------------------------------------------------


            //---------------Will always provide right output---------------
            if (Equals(sample, null))
            {
                Console.WriteLine(".Equals operator returns null correctly");
            }
            else
            {
                Console.WriteLine(".Equals operator fails to return null");
            }
            //---------------------------------------------------------------


            sample = new Equals_EqualToOperator();
            //sample can be null, which leads to exception
            if (sample.Equals(new Equals_EqualToOperator()))
            {

            }
            else
            {

            }



        }

    }
}

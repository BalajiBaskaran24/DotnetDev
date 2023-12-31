﻿using ExploreCSharp.SOLID.LiskovSubs;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    public class DelegatesandLambda
    {
        public static void DefaultDelUsage()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            //Func::: return type can be defined
            Func<string, int, bool> predicate = (fruit, index) => fruit.Length > 5 && index % 2 == 0;// Define the Func<TSource, int, bool> predicate
            var filteredFruits = fruits.Where(predicate);// Use the predicate with LINQ's Where method

            //Action::: Return type cannot be defined
            Action<string> Act = (ActInp) => Console.WriteLine(ActInp);
            Act("Input of action method");
        }

        #region Declaring and using a delegate

        //When any of the methods throws an exception that is not caught within the method, 
        //that exception is passed to the caller of the delegate and no subsequent methods in the 
        //invocation list are called. If the delegate has a return value and/or out parameters, 
        //it returns the return value and parameters of the last method invoked.


        /// <summary>
        /// Delegate, takes string as parameter and returns string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public delegate string Reverse(string s);

        /// <summary>
        /// Sample method that matches Reverse delegate signature
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReverseStringDel(string s)
        {
            Console.WriteLine("Called ReverseStringDel with" + s);
            return new string($"{s} ReverseStringDel ");
        }

        /// <summary>
        /// Sample method that matches Reverse delegate signature
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReverseToOriginal(string s)
        {
            Console.WriteLine("Called ReverseToOriginal with" + s);
            return new string($"{s} ReverseToOriginal ");
        }

        public static void UsageDel()
        {
            try
            {
                //Multicase delegate
                Reverse rev1 = ReverseStringDel;//Binding method and delegate
                Reverse rev2 = ReverseToOriginal;
                Reverse Consolidated = rev1 + rev2 + rev1;
                Console.WriteLine(Consolidated("a string del"));
                //Output::
                //Called ReverseStringDel witha string del
                //Called ReverseToOriginal witha string del
                //Called ReverseStringDel witha string del
                //a string del ReverseToOriginal

                Consolidated -= rev2;//Removing rev2 delegate from consolidated list
                Consolidated -= rev2;
                Consolidated("After rev2 removal");
                //output::
                //Called ReverseStringDel withAfter rev2 removal
                //Called ReverseStringDel withAfter rev2 removal


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion

        #region Using Function

        /// <summary>
        /// Sample method that matches the lambda expression
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReverseStringFunc(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static void UsageFunc()
        {
            Func<string, string> rev = ReverseStringFunc;//Binding lambda and method
            Console.WriteLine(rev("a string"));
        }

        #endregion

        /// <summary>
        /// Passing delegate as parameter 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="callback"></param>
        public static void MethodWithCallback(int param1, int param2, Reverse callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

    }
}

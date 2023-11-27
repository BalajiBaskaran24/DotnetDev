using Microsoft.Diagnostics.Tracing.Parsers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.ReferenceTypes
{
    interface ISample2Interface
    {
        int SameMthdName();
        int SameVarName { get; set; }
    }

    interface ISampleInterface
    {
        void SampleMethod();

        static ISampleInterface()
        {

        }

        //int Prop { get; private set; } This will throw error. Private set is not allowed

        //public bool Sample; Inteface cannot contain instance fields

        int SampleProp { get; set; }//Allowed, since user can define a logic for getter and setter methods

        int SameVarName { get; set; }

        int SameMthdName();

        /// <summary>
        /// In new version its possible to define method in interface itself
        /// </summary>
        void NewVersionSampleMethod()
        {
            Console.WriteLine("Method defined in interface");
        }
    }
    class ImplementationClass : ISampleInterface, ISample2Interface
    {
        /// <summary>
        /// Should be implemented as part of ISampleInterface
        /// </summary>
        public int SampleProp { get; set; }

        public int SameName { get; set; }

        public int MyProperty
        {
            get
            {
                return 0;
            }
            set
            {
                
            }
        }

        public int SameVarName
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        int ISampleInterface.SameMthdName()
        {
            return 0;
        }

        int ISample2Interface.SameMthdName()
        {
            return 0;
        }

        /// <summary>
        /// Should be implemented as part of ISampleInterface
        /// </summary>
        void ISampleInterface.SampleMethod()
        {
            // Method implementation
        }
    }

    public class InterfaceStarter
    {
        public void Starter()
        {

        }
    }


}

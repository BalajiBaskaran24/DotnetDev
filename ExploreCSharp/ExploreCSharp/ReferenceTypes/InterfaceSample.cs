using Microsoft.Diagnostics.Tracing.Parsers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.ReferenceTypes
{
    //Default access is public

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

        /// <summary>
        /// Should be implemented as part of ISampleInterface
        /// </summary>
        void ISampleInterface.SampleMethod()
        {
            // Method implementation
        }

        #region Explicit implementation

        //If class implements interface with same method/property name
        //use interface name to write definition 

        //CS0106
        //An explicit interface implementation doesn't have an access modifier
        //since it isn't accessible as a member of the type it's defined in. Instead,
        //it's only accessible when called through an instance of the interface. If you
        //specify an access modifier for an explicit interface implementation, you get compiler error

        int ISample2Interface.SameVarName { get; set; }

        int ISampleInterface.SameVarName
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

        #endregion



    }

    public class InterfaceStarter
    {
        public void Starter()
        {
            ISample2Interface sample2Interface = new ImplementationClass();
            sample2Interface.SameVarName = 1;

            ImplementationClass implementationClass = new ImplementationClass();
            //Below lines will throw error. CS0106
            //implementationClass.SameMthdName
            //implementationClass.SameVarName
        }
    }


}

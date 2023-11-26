using Microsoft.Diagnostics.Tracing.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.ReferenceTypes
{
    interface ISampleInterface
    {
        void SampleMethod();

        static ISampleInterface()
        {

        }

        //int Prop { get; private set; } This will throw error

        //public bool Sample; Inteface cannot contains instance fields
        
        int SampleProp { get; set; }

        
        /// <summary>
        /// In new version its possible to define method in interface itself
        /// </summary>
        void NewVersionSampleMethod()
        {
            Console.WriteLine("Method defined in interface");
        }
    }
    class ImplementationClass : ISampleInterface
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
    }


}

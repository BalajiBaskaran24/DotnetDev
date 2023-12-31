﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    /// <summary>
    /// Has a missing or incomplete implementation
    /// 
    /// Used in classes, methods, properties, indexers, and events
    /// 
    /// Abstract classes cannot be instantiated on its own
    /// 
    /// Cannot be used with sealed KW since both have opposite behavior
    /// </summary>
    public abstract class AbstractKW
    {

    }



    interface IBase
    {
        void IntMethod();

        void IntMethod1();

        void IntMethod2()
        {

        }
        void IntMethod3()
        {

        }
    }

    public abstract class Base : IBase
    {
        /// <summary>
        /// Marks interface method as abstract
        /// </summary>
        public abstract void IntMethod();

        /// <summary>
        /// Implements interface method
        /// </summary>
        public void IntMethod1()
        {

        }

        /// <summary>
        /// Mark abstract for default implementation in interface
        /// </summary>
        public abstract void IntMethod2();

        // Abstract properties
        public abstract int X { get; }
        public abstract int Y { set; }
    }

    public class Children : Base
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Overriding property
        /// </summary>
        public override int X
        {
            get
            { return _x + 10; }
        }

        /// <summary>
        /// Overriding property
        /// </summary>
        public override int Y
        {
            //get{} This will throw error

            set
            { _y = value; }
        }

        /// <summary>
        /// Will throw error since its not an abstract class
        /// </summary>
        //public abstract void SampleAbsMethod(){}

        public override void IntMethod()
        {
        }

        //This will throw error since its not virtual/abstract keywords
        //are not mentioned
        //public override void IntMethod1()
        //{
        //}

        /// <summary>
        /// Override the default interface method
        /// </summary>
        public override void IntMethod2() { }

        /// <summary>
        /// Implement default implemented method. 
        /// Use of override keyword will throw error because its not abstract method
        /// </summary>
        public void IntMethod3() { }
    }
}

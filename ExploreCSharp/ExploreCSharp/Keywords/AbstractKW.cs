using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class AbstractStarter
    {
        public static void Starter()
        {
            //ImpAbsWithCons impAbsWithCons = new ImpAbsWithCons(5);

        }
    }

    interface IBase
    {
        void IntMethod();

        void IntMethodImpInAbs();

        public void IntMethodImpInInt()
        {
            Console.WriteLine("In interface");
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
        public void IntMethodImpInAbs()
        {

        }
        public abstract void IntMethodImpInInt();

        public virtual void DuplicateAbsMethod() { }

        // Abstract properties
        public abstract int X { get; }
        public abstract int Y { set; }
    }

    public class Children : Base
    {
        private int _x;
        private int _y;

        // Overriding property
        public override int X
        {
            get
            { return _x + 10; }
        }

        // Overriding property
        public override int Y
        {
            //get{} This will throw error

            set
            { _y = value; }
        }

        //Will throw error since its not an abstract class
        //public abstract void SampleAbsMethod(){}

        public override void IntMethod()
        {
        }

        public override void IntMethodImpInInt()
        {
            Console.WriteLine("In children");
        }

        public void DuplicateAbsMethod()
        {
            
        }
    }

    #region Abstract class with constructor

    public abstract class AbswithConsGrand
    {
        public AbswithConsGrand()
        {

        }
        public AbswithConsGrand(int param1)
        {
            Console.WriteLine("Calling abstract class grand constructor");
        }
    }

    public abstract class AbswithCons : AbswithConsGrand
    {
        //public AbswithCons()
        //{

        //}
        public AbswithCons(int param1) : base(param1)
        {
            Console.WriteLine("Calling abstract class constructor");
        }
    }

    public class ImpAbsWithCons : AbswithCons
    {
        /// <summary>
        /// Abstract class constructor will be called first, 
        /// then constructor of actual implementation
        /// </summary>
        /// <param name="param"></param>
        public ImpAbsWithCons(int param) : base(param)
        {
            Console.WriteLine("Implementation class constructor");
        }
    }

    #endregion

    #region abstract class cannot be sealed or static
    //public abstract static class SampleStatic
    //{

    //}
    #endregion

    #region Abstract class inside abstract class
    public abstract class NonAbstract
    {
        public abstract class InnerClass
        {

        }
    }

    #endregion

    #region Class accessibility should be consistent between the base class and inherited class.

    public class InternalAbs
    {
        NonAbstract.InnerClass InnerClass;
        NonAbstract NonAbsClass;
        public void NewMethod()
        {
        }
    }

    //Below decleration will throw error
    //public class PublicAbsClass : InternalAbs
    //{
    //}

    #endregion

    #region Multi Level abstract classes

    public abstract class BaseAbstractGrand : NonAbstract
    {
        public abstract string Name { get; }

        public abstract void SampleMethod();
    }
    public abstract class BaseAbstractFather : BaseAbstractGrand
    {

    }
    public abstract class BaseAbstractSon : BaseAbstractFather
    {

    }
    public class Derived : BaseAbstractSon
    {
        public override string Name { get; }

        public override void SampleMethod()
        {

        }
    }

    #endregion

    #region Class can implement only one abstract class

    public abstract class BaseAbs1
    {

    }

    public abstract class BaseAbs2
    {

    }

    //Below implementation will throw error
    //public class Der : BaseAbs1, BaseAbs2
    //{

    //}

    #endregion
}

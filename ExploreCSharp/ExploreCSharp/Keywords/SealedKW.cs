using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords
{
    /// <summary>
    /// KEYWORDS COVERED: sealed
    /// Sealed modifier prevents other classes from inheriting from it
    /// </summary>
    public sealed class SealedKW
    {
        public SealedKW()
        {

        }
    }


    public class ExtendsSealedClass//   """ : SampleSealedClass """
                                   // This will throw error since its sealed class
    {

    }


    public class BaseClass
    {
        public virtual void VirtualMethod()
        {

        }

        public virtual void Method2()
        {

        }
    }

    public class DerivedClass : BaseClass
    {
        /// <summary>
        /// sealed modifier - used in method or property that overrides a virtual 
        /// method or property in a base class. This enables you to allow classes to derive from your class 
        /// and prevent them from overriding specific virtual methods or properties.
        /// 
        /// Always used with override keyword
        /// </summary>
        public sealed override void VirtualMethod()
        {

        }

        public override void Method2()
        {

        }
    }

    public class ChildClass : DerivedClass
    {
        public override void Method2()
        {

        }

        //Below line Will throw error since its sealed
        //public override void VirtualMethod(){}
    }

    /// <summary>
    /// Sealed keywords cannot be used/applicable while implementing interface methods
    /// </summary>
    public interface IInterface
    {
        public void InterfaceMethod() { }

        public void InterfaceMethod2();
    }

    public class ImpInterface : IInterface
    {
        public void InterfaceMethod2()
        {

        }

        
    }


}

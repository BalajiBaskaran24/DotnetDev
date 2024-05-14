using Lib2;

namespace Lib1
{
    public class Lib1Class1 : Lib2Class1
    {
        public Lib1Class1()
        {
            ProtVar = 0;
            //PriPro = 0;private protected cannot be accessed in different assembly
        }
    }

    public class Lib1Class2
    {
        Lib2Class1 lib2Class1 = new Lib2Class1();
        public Lib1Class2()
        {
            //This is inaccessible due to its protection level
            //lib2Class1.ProtVar
        }
    }
}



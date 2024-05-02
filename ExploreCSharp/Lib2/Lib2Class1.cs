namespace Lib2
{

    /// <summary>
    /// </summary>
    public class Lib2Class1
    {
        /// <summary>
        /// This can be used only in derived class
        /// </summary>
        protected int ProtVar = 0;

        private protected int PriPro = 0;

        private int Pri = 0;
    }

    public class Lib2Class2
    {
        Lib2Class1 Lib2Class1 { get; set; }
        public Lib2Class2()
        {
            //Cannot be accessed due to its protection level
            //Lib2Class1.ProtVar
            //Lib2Class1.PriPro
            //Lib2Class1.Pri
        }
    }

    public class Lib2Class3 : Lib2Class1
    {
        /// <summary>
        /// 
        /// </summary>
        public Lib2Class3()
        {
            PriPro = 0;//private protected can be accessed in same assembly
            ProtVar = 0;
            //Pri = 0; Cannot be accessed due to its protection level
        }
    }



    public interface Lib2Interface1
    {
        protected int ProtVar { get; set; }
        internal int InternalVar { get; set; }
        protected void ProtMthdInInterface();

        //"Must have body" as per v8.0
        //"Default interface implementation cannot be done" < 8.0 versions
        //private void PvtMthdInInterface();
    }
}

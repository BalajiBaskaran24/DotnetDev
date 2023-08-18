using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreCSharp.SOLID;
using ExploreCSharp.DependencyInjection.VSExample;
using ExploreCSharp.Keywords;

namespace ExploreCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int 
            int x = 1, y = 2;
            int z = x / y;

            //Var and dynamic keyword usage
            VarDynamic.Usage();

            //2D array methods
            //TwoDArray.TwoDArray.Starter2D();

            //Various swap methods
            //int RefSample = 5;
            //Electronics.ExploreEle.Swap(ref RefSample, ref RefSample);


            //SOLIDSample sOLID = new SOLIDSample();
            //sOLID.TriggerL();

            //DIPStarter.Execute();

            //== and .Equals comparison
            //Equals_EqualToOperator.StarterEquals();
        }
    }
}

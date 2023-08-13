using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreCSharp.SOLID;
using ExploreCSharp.DependencyInjection.VSExample;

namespace ExploreCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Various swap methods
            Electronics.Explore.Swap(1, 1);


            //SOLIDSample sOLID = new SOLIDSample();
            //sOLID.TriggerL();

            //DIPStarter.Execute();

            //== and .Equals comparison
            //Equals_EqualToOperator.StarterEquals();
        }
    }
}

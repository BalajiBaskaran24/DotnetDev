using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRef.SOLID;
using ExploreCSharp.DependencyInjection.VSExample;

namespace ExploreCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SOLIDSample sOLID = new SOLIDSample();
            //sOLID.TriggerL();

            DIPStarter.Execute();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample
{
    /// <summary>
    /// TPR factory
    /// </summary>
    internal class MPPTPRFactory : IWirelessModulesFactory
    {
        public IWirelessModules CreateWirelessModule()
        {
            Console.WriteLine("MPPTPR created by MPPTPRFactory");
            return new MPPTPR();
        }
    }
}

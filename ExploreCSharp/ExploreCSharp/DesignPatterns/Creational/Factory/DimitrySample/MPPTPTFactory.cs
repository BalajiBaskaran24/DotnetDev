using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample
{
    internal class MPPTPTFactory : IWirelessModulesFactory
    {
        /// <summary>
        /// TPT factory
        /// </summary>
        /// <returns></returns>
        public IWirelessModules CreateWirelessModule()
        {
            Console.WriteLine("MPPTPT created by MPPTPTFactory");
            return new MPPTPT();
        }
    }
}

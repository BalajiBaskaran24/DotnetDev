using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample;

/// <summary>
/// MPP TPR module 
/// </summary>
internal class MPPTPR : IWirelessModules
{
    public void PrintTitle()
    {
        Console.WriteLine("Printing MPP TPR module");
    }
}

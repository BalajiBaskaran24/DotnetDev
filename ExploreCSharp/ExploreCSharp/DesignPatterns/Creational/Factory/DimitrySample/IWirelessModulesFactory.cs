using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample;

/// <summary>
/// Factory to create instance for wireless modules
/// </summary>
interface IWirelessModulesFactory
{
    public IWirelessModules CreateWirelessModule();
}

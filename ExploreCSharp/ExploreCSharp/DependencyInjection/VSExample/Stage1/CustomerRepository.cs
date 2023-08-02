using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage1
{
    public class CustomerRepository
    {
        public void Save()
        {
            Console.WriteLine("Customer purchase saved.");
        }
    }
}

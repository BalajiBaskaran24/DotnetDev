using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage2
{
    public class CustomerRepository : ICustomerRepository
    {
        void ICustomerRepository.Save()
        {
            Console.WriteLine("Customer purchase saved.");
        }
    }

    public interface ICustomerRepository
    {
        void Save();
    }
}

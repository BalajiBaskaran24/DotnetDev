using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage3
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ILogger logIns;

        public CustomerRepository(ILogger logIns)
        {
            this.logIns = logIns;
        }
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

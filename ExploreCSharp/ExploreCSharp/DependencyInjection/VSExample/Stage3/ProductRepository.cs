using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage3
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(ILogger logger)
        {
            _Logger = logger;
        }

        ILogger _Logger;

        void IProductRepository.Save()
        {
            Console.WriteLine("Product inventory updated.");
            _Logger.Log("Inventory update complete.");
        }
    }

    public interface IProductRepository
    {
        void Save();
    }
}

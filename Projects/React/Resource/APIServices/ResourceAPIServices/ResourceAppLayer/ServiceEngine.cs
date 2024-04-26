using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAppLayer
{
    public class ServiceEngine : IServiceEngine
    {
        /// <summary>
        /// Database service
        /// </summary>
        public IDBConnector DataFetchService { get; }

        public ServiceEngine(IDBConnector dataFetchService)
        {
            DataFetchService = dataFetchService;
        }
    }
}

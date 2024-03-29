using DataAccess;

namespace ResourceAppLayer
{
    public interface IServiceEngine
    {
        /// <summary>
        /// Database service
        /// </summary>
        public IDBConnector DataFetchService { get; }
    }
}

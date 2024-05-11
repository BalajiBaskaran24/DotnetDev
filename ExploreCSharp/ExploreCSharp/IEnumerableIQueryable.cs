using BenchmarkDotNet.Disassemblers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    internal class IEnumerableIQueryable
    {
        /// <summary>
        /// Using ADO Net connect with MS SQL Database
        /// </summary>
        public void ConnectWithDB()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DiffMethod()
        {

            List<int> numbers = new List<int> { 1, 2, 3 };
            IEnumerable<int> result = numbers.Where(n => n > 1);
            foreach (int n in result) { Console.WriteLine(n); }



            IQueryable<int> query = ;//dbContext.Numbers.Where(n => n > 1);
            List<int> QueryResult = query.ToList();
        }
    }
}

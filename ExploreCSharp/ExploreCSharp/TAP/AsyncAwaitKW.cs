using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.TAP
{
    public class AsyncAwaitKW
    {
        public static async Task<int> SampleAsyncMethod()
        {
            try
            {
                Console.WriteLine("Start of method");
                await Task.Run(HelperClass);
                Console.WriteLine("End of method");
            }
            catch (Exception ex)
            {

            }
            return 2;
        }

        public static async Task HelperClass()
        {
            Console.WriteLine("start of HelperCLass");
            await Task.Delay(5000);
            Console.WriteLine("End of HelperCLass");

        }
    }
}

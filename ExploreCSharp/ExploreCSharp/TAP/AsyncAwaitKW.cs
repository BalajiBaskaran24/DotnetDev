using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.TAP
{
    public class AsyncAwaitKW
    {
        public static async Task SampleAsyncMethod()
        {
            try
            {
                //Console.WriteLine("Start of method");
                //await Task.Run(() =>
                //{
                //    try
                //    {
                //        Console.WriteLine("Task 2s");
                //        Thread.Sleep(2000);
                //        HelperClass();
                //    }
                //    catch (Exception ex)
                //    {

                //    }
                //}
                //);
                //Console.WriteLine("End of method");
                Console.WriteLine("Start of method");
                await Task.Run(HelperClass);
                Console.WriteLine("End of method");
            }
            catch (Exception ex)
            {

            }
        }

        public static async Task HelperClass()
        {
            Console.WriteLine("st HelperCLass");
            await Task.Delay(10000);
            Console.WriteLine("HelperCLass");

        }
    }
}

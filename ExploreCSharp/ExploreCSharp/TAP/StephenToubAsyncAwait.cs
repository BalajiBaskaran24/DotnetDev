using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.TAP
{
    public class StephenToubAsyncAwait
    {

        public static void Starter()
        {
            for (int i = 0; i < 1000; i++)
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                });
            }

            Console.ReadLine();
        }
    }
}

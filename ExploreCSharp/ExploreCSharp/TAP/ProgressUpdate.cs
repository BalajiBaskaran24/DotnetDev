using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.TAP
{
    internal class ProgressUpdate
    {
        public static async Task Starter()
        {
            // Create an instance of Progress<T>, specifying the type of progress report data.
            var progressIndicator = new Progress<int>(ReportProgress);

            // Run the asynchronous operation and pass the IProgress<T> instance.
            await LongRunningOperationAsync(progressIndicator);

            Console.WriteLine("Operation completed.");
        }

        // Method to report progress.
        private static void ReportProgress(int value)
        {
            Console.WriteLine($"Progress: {value}%");
        }

        // Simulates a long-running operation, reporting progress updates.
        private static async Task LongRunningOperationAsync(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                // Simulate a part of the long-running work.
                //await Task.Delay(500); // Delay to simulate work.
                Task.Delay(100).Wait();
                // Report progress.
                progress?.Report(i);
            }
        }
    }
}


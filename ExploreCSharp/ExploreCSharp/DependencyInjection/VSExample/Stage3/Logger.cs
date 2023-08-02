using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage3
{
    public class Logger : ILogger
    {
        void ILogger.Log(string message)
        {
            Type thisType = GetType();
            Console.WriteLine("Message logged: {0}", message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}

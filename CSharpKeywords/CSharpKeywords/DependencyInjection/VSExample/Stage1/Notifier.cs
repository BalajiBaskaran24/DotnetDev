using CSharpRef.DependencyInjection.VSExample;
using System;
using System.Linq;

namespace CSharpRef.DependencyInjection.VSExample.Stage1
{
    public class Notifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt
            Console.WriteLine(string.Format("Receipt sent to customer '{0}' via email.", orderInfo.CustomerName));
        }
    }
}

using System;
using System.Linq;

namespace ExploreCSharp.DependencyInjection.VSExample.Stage1
{
    /// <summary>
    /// To create instance of all high level data model in one single place. 
    /// Instance creation singleton/scoped/transient based on user requirement
    /// </summary>
    public class BillingProcessor
    {
        public void ProcessPayment(string customer, string creditCard, double price)
        {
            // perform billing gateway processing
            Console.WriteLine(string.Format("Payment processed for customer '{0}' on credit card '{1}' for {2:c}.", customer, creditCard, price));
        }
    }
}

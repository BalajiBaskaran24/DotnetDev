using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    /// <summary>
    /// keywords: required
    /// </summary>
    public class Properties
    {

    }

    public class PropertiesStarter
    {
        public static void Starter()
        {
            //The below statement will throw error untill and unless Name and Price is not defined
            //Since required keyword is used in the below properties

            SaleItem Item = new SaleItem() { Name = "C2", Price = 40 };

            //This is allowed if [SetsRequiredMembers] is added to primary constructor
            //Complier will not check whether all required properties are initialized
            //Also allows user to create new instance

            //SaleItem Item = new();
        }
    }

    public class SaleItem
    {
        //[SetsRequiredMembers]
        //public SaleItem()
        //{

        //}

        public required string Name
        { get; set; }

        public required decimal Price
        { get; set; }
    }
}

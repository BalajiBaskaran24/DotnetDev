using ExploreCSharp.Keywords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class ValueReferenceTypes
    {

        public void ListAdd()
        {
            List<SampleClass1> SM1 = new List<SampleClass1>();
            SampleClass1 data = new SampleClass1("first") { SampleInt = 1 };
            SM1.Add(data);
            data = new SampleClass1("second") { SampleInt = 1 };
            SM1.Add(data);

            data.SampleStr = "third";
            data.SampleInt = 3;//Both second element in list and data will be updated
        }
    }
}

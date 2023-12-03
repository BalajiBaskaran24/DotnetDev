using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Factory
{
    public class FactoryProperty
    {
        public static void Starter()
        {
            SampleModel PropIns = SampleModel.Instance;
            Console.WriteLine(SampleModel.Instance);
        }

    }

    public class SampleModel
    {
        public SampleModel()
        {
            Console.WriteLine("Instance for sample model is created");
        }
        public static SampleModel Instance => new SampleModel();

        public static SampleModel InstanceField = new SampleModel();
    }

}

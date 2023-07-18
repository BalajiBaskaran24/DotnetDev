using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference
{
    public class Sample
    {
        public Sample() { }
        public int QueueIndex;
        public int Value;
        public double TimeStamp;
    }
    public class PriorityQueueEx
    {
        PriorityQueue<Sample, double> PQueue = new(new SampleComparer());

        public void AddSample()
        {
            PQueue.Clear();
            PQueue.Enqueue(new Sample() { TimeStamp = 1 }, 1);
            PQueue.Enqueue(new Sample() { TimeStamp = 2 }, 2);
            PQueue.Enqueue(new Sample() { TimeStamp = 3 }, 3);
            PQueue.Enqueue(new Sample() { TimeStamp = 5 }, 5);
            PQueue.Enqueue(new Sample() { TimeStamp = 6 }, 6);
            PQueue.Enqueue(new Sample() { TimeStamp = 7 }, 7);
            PQueue.Enqueue(new Sample() { TimeStamp = 4 }, 4);
        }
    }


    public class SampleComparer : IComparer<double>
    {
        public int Compare(double newVal, double existVal)
        {
            if (newVal < existVal)
            {
                return -1;
            }
            else
                return 1;
        }
    }
}

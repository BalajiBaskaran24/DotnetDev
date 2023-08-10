using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Recursion
{
    public class SubsetSum
    {
        //Problem description
        //Given a list of n integers. print sum of all subsets in increasing order of sums.
        //Input N=2 Arr=[2,3]
        //Output 0 2 3 5(2+3)


        public static void PrintSum(int ind, int sum, List<int> data, List<int> sumSubset)
        {
            if (ind == data.Count)
            {
                sumSubset.Add(sum);
                return;
            }

            //Pick
            PrintSum(ind + 1, sum + data[ind], data, sumSubset);

            //Not pick
            PrintSum(ind + 1, sum, data, sumSubset);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray;

/// <summary>
/// Company name: KLA
/// Level: Easy
/// If number k appears exactly k times continuous - Alpha
/// If number k appears exactly k times and starts from kth index - Beta
/// </summary>
public class AlphaBeta
{

    /// <summary>
    /// 0 1 2 2 4 4 4 4 3 3 3
    /// alpha - 4
    /// beta - 2
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Alpha, beta</returns>
    public Tuple<int, int> Solution(List<int> input)
    {
        //Start with Counter value 1. Because counter increases only by one for each comparison
        int Counter = 1, Alpha = 0, Beta = 0;
        for (int i = 0; i < input.Count - 1; i++)//Iterate till n-1 since comparison is involved
        {
            if (input[i] == input[i + 1])//Increment the counter untill consecutive values are same
            {
                Counter += 1;
            }
            else
            {
                if (Counter == input[i])//Update alpha and beta values
                {
                    Alpha += 1;
                    if (i - (Counter - 1) == input[i])//Start index should be equal to value
                    {
                        Beta += 1;
                    }
                }
                Counter = 1;
            }
        }
        if (Counter == input.Last())//To handle last element of list
        {
            Alpha += 1;
            if (input.Count - Counter == input.Last())
            {
                Beta += 1;
            }
        }
        return new Tuple<int, int>(Alpha, Beta);
    }
}
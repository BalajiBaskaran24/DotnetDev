using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays;

public class AlphaBeta
{
    //If number k appears exactly k times - Alpha
    //If number k appears exactly k times and starts from kth index

    public Tuple<int, int> Solution(List<int> input)
    {
        int Counter = 1, Alpha = 0, Beta = 0;
        for (int i = 0; i < input.Count - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                Counter += 1;
            }
            else
            {
                if (Counter == input[i])
                {
                    Alpha += 1;
                    if ((i - (Counter - 1)) == input[i])
                    {
                        Beta += 1;
                    }
                }
                Counter = 1;
            }
        }
        if (Counter == input.Last())
        {
            Alpha += 1;
            if ((input.Count - Counter) == input.Last())
            {
                Beta += 1;
            }
        }
        return new Tuple<int, int>(Alpha, Beta);
    }
}

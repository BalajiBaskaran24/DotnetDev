using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.DynamicProgramming
{
    public class Strings
    {
        public static int MinimumDeleteSum(string s1, string s2)
        {
            int[,] dp = new int[s1.Length + 1, s2.Length + 1];

            // Fill the last row
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                dp[i, s2.Length] = dp[i + 1, s2.Length] + s1[i];
            }

            // Fill the last column
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                dp[s1.Length, i] = dp[s1.Length, i + 1] + s2[i];
            }

            // Fill the rest of the table
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                for (int j = s2.Length - 1; j >= 0; j--)
                {
                    if (s1[i] == s2[j])
                    {
                        dp[i, j] = dp[i + 1, j + 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i + 1, j] + s1[i], dp[i, j + 1] + s2[j]);
                    }
                }
            }

            return dp[0, 0];
        }

    }
}

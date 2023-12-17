using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray;

public class DeciBinary
{
    //LEET
    //A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros.
    //For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.

    /// <summary>
    /// Input: n = "32" Output: 3 (10 + 11 + 11) [three decibinary numbers are required]
    /// Input: n = "82734" Output: 8 
    /// 
    /// LOGIC: Return value depends on maximum number present in a given string
    /// [- '0'] is performed to subtract the ASCII value of '0' character
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int MinPartitions(string n)
    {
        //return n.Max() - '0';
        char x = n.Max();//Returns a maximum character in a given string 
        int diff = x - '0';
        return 0;
    }
}

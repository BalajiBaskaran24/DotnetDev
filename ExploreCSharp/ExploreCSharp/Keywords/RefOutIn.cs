using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords;

/// <summary>
/// Ref/out/in keywords
/// </summary>
public class RefOutIn
{
    #region Ref keyword

    /// <summary>
    /// When you declare a local variable and add the ref keyword before the variable's type, 
    /// you declare a reference variable, or a ref local
    /// </summary>
    public void ReferenceVariables()
    {
        int a = 1;
        ref int alias = ref a;
        Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (1, 1)

        a = 2;
        Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (2, 2)

        alias = 3;
        Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (3, 3)
    }

    /// <summary>
    /// Pass variable as reference type argument
    /// </summary>
    /// <param name="refArgument">Reference parameter</param>
    void Method(ref int refArgument)
    {
        refArgument = refArgument + 44;
    }

    public void RefStarter()
    {
        //int number;
        //Method(ref number);//CS0165: Use of unassigned local variable 'name'

        //Method that calls signature with ref parameter is responsible for initialization
        int number = 1;
        Method(ref number);//Pass number variable as reference parameter
        Console.WriteLine(number);
        //Output: 45
    }

    public void RefReturnTypeStarter()
    {
        int[] xs = new int[] { 10, 20, 30, 40 };
        ref int found = ref FindFirst(xs, s => s == 30);
        found = 0;
        Console.WriteLine(string.Join(" ", xs));// output: 10 20 0 40
    }

    /// <summary>
    /// Sample method for return type as reference
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="predicate"></param>
    /// <returns>Variable as reference</returns>
    /// <exception cref="InvalidOperationException"></exception>
    ref int FindFirst(int[] numbers, Func<int, bool> predicate)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (predicate(numbers[i]))
            {
                return ref numbers[i];
            }
        }
        throw new InvalidOperationException("No element satisfies the given condition.");
    }

    #endregion


    #region Out keyword

    public void OutAsParamStarter()
    {
        int initializeInMethod;
        OutArgExample(out initializeInMethod);//Doesn't throw "Use of unassigned local variable 'name'"
        Console.WriteLine(initializeInMethod);//Value is now 44
    }

    /// <summary>
    /// Method takes out param as input
    /// </summary>
    /// <param name="number"></param>
    void OutArgExample(out int number)
    {
        //Possible errors in out
        //The out parameter 'parameter' must be assigned to before control leaves the current method
        //Conclusion: Method with out parameter will be responsible for initialization
        int i = 1;
        number = 44;


        //int localvar;
        //Console.WriteLine(localvar);Error: Use of unassigned local variable 'name'
    }

    #endregion

    #region in keyword

    public void InKWStarter()
    {
        int readonlyArgument = 44;
        InArgExample(readonlyArgument);
        Console.WriteLine(readonlyArgument);     // value is still 44
    }

    /// <summary>
    /// Takes readonly variable as parameter (in)
    /// </summary>
    /// <param name="number"></param>
    void InArgExample(in int number)
    {

        //CS8331::Cannot assign to variable or use it as the right hand
        //side of a ref assignment because it is a readonly variable

        //number = 19;
    }

    #endregion
}

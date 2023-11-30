using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.Keywords;

/// <summary>
/// Class that explains operator overloading
/// KEYWORDS COVERED: operator
/// </summary>
public class OpOverloadingClass
{
    public int Value { get; set; }

    /// <summary>
    /// Operator keyword is required
    /// Public and Static modifiers are required since the operators are associated to class itself
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static OpOverloadingClass operator +(OpOverloadingClass a, OpOverloadingClass b)
    {
        return new OpOverloadingClass { Value = a.Value + b.Value };
    }
}

public class OpOverloadingSample
{
    public static void Starter()
    {
        OpOverloadingClass obj1 = new OpOverloadingClass { Value = 10 };
        OpOverloadingClass obj2 = new OpOverloadingClass { Value = 20 };

        var result = obj1 + obj2;

        //Complier will consider the above line as below
        //var result = OpOverloadingClass.operator +(obj1, obj2);

        Console.WriteLine(result.Value); // Output: 30
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp;

public class MyClass
{
    public int Value { get; set; }

    /// <summary>
    /// Static is required since the operators are associated to class itself
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass { Value = a.Value + b.Value };
    }
}

public class OpOverloadingSample
{
    public static void Starter()
    {
        MyClass obj1 = new MyClass { Value = 10 };
        MyClass obj2 = new MyClass { Value = 20 };

        var result = obj1 + obj2;

        //Complier will consider the above line as below
        //var result = MyClass.operator +(obj1, obj2);

        Console.WriteLine(result.Value); // Output: 30
    }
}

namespace ExploreCSharp.Keywords;
public enum UserDefEnum
{ }

public class UserDefClass
{ }

/// <summary>
/// The where clause in a generic definition specifies constraints on the types 
/// that are used as arguments for type parameters in a generic type, method, delegate,
/// or local function. Constraints can specify interfaces, base classes, or require a 
/// generic type to be a reference, value, or unmanaged type.
/// </summary>
public class WhereKW
{

    public WhereKW() { }

    public void WhereStarter()
    {
        //When a constraint is applied to a generic type parameter, an implicit identity or reference
        //conversion must exist from the concrete argument to the type of the constraint.

        //There is no implicit reference conversion from UserDefClass to System.Enum
        //SampleEn<UserDefClass> sampleClass = new SampleEn<UserDefClass>();//Will throw error

        SampleEn<UserDefEnum> sampleenum = new SampleEn<UserDefEnum>();//no error
        SampleClass<UserDefClass> sampleClass = new SampleClass<UserDefClass>();
    }
}
public class SampleEn<T> where T : Enum
{

}

public class SampleClass<T> where T : UserDefClass
{

}

public class MyGenericClass<T> where T : IComparable<T>, new()
{
    // The following line is not possible without new() constraint:
    T item = new T();
}

//-----------Constraint: Accepts Class which contains default constructor
class ItemFactory<T> where T : new()
{
    public T GetNewItem()
    {
        // The following line is not possible without new() constraint:
        return new T();
    }
}

/// <summary>
/// If class contains any parameterized constructor then constructor with no parameters will not be created
/// </summary>
class SampleClassWithoutConstructor
{
    public SampleClassWithoutConstructor(int temp)
    {

    }
}


class GenericUsage
{
    public GenericUsage() { }

    public void Method()
    {
        //ItemFactory will accept the type that has default constructor. Since SampleClassWithoutConstructor doesnt have
        //default constructor it will throw error.
        //ItemFactory<SampleClassWithoutConstructor> item = new ItemFactory<SampleClassWithoutConstructor>();
    }
}


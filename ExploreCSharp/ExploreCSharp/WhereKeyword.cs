namespace ExploreCSharp;
public enum UserDefEnum
{ }

public class UserDefClass
{ }
public class WhereKeyword
{

    public WhereKeyword() { }

    public void WhereStarter()
    {
        //When a constraint is applied to a generic type parameter, an implicit identity or reference
        //conversion must exist from the concrete argument to the type of the constraint.
        //SampleEn<UserDefClass> sampleClass = new SampleEn<UserDefClass>();//Will throw error
        SampleEn<UserDefEnum> sampleenum = new SampleEn<UserDefEnum>();//no error
        SampleClass<UserDefClass> sampleClass = new SampleClass<UserDefClass>();
    }
}
public class SampleEn<T> where T : System.Enum
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

class ItemFactory<T> where T : new()
{
    public T GetNewItem()
    {
        // The following line is not possible without new() constraint:
        return new T();
    }
}

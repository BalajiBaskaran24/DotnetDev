
using DSAndAlgoReference;
using DSAndAlgoReference.Hashing.CollisionHandling;

public enum Option
{
    Stack_List,
    Stack_Array,
    None
}

public class Program
{
    public static void Main(string[] args)
    {

        LLChainingHelper.Starter();

        List<int> IntLst = new List<int>();
        List<int>[] ArrayofList = new List<int>[10];
        //ArrayofList[0].Add(0);//will throw exception. Since constructor is not called here
        ArrayofList[0] = new List<int>();
        ArrayofList[0].Add(0);//This will not create any error

        PriorityQueueEx Sample = new PriorityQueueEx();
        Sample.AddSample();

        Option ReqType = Option.None;
        switch (ReqType)
        {
            case Option.Stack_List:
                StackLst<int> stackLst = new();

                stackLst.Push(1);
                stackLst.Push(2);
                stackLst.Push(3);

                Console.WriteLine(stackLst.Peek());  // Output: 3

                int poppedItem = stackLst.Pop();
                Console.WriteLine(poppedItem);    // Output: 3

                Console.WriteLine(stackLst.Peek());  // Output: 2
                break;
            case Option.Stack_Array:
                StackArr<int> stackArr = new(5);

                stackArr.Push(1);
                stackArr.Push(2);
                stackArr.Push(3);

                Console.WriteLine(stackArr.Peek());  // Output: 3

                poppedItem = stackArr.Pop();
                Console.WriteLine(poppedItem);    // Output: 3

                Console.WriteLine(stackArr.Peek());  // Output: 2
                break;
            default:
                break;
        }
    }
}
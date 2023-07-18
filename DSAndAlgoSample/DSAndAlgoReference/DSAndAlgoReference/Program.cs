
using DSAndAlgoReference;

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

        PriorityQueueEx Sample=new PriorityQueueEx();
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

using DSAndAlgoReference;
using DSAndAlgoReference.Hashing.CollisionHandling;
using DSAndAlgoReference.SampleProblems;
using DSAndAlgoReference.SampleProblems.DynamicProgramming;
using DSAndAlgoReference.SampleProblems.Recursion;

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
        Console.Clear();

        int t = 0;
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> ds = new List<int>();
        CombinationSum.FindCombinations_OnlyRecursion(new int[3] { 1, 2, 3 }, 12, 0, ds, ans);
        int Output1 = RecursionMethods.CountDigitOne_WoRec(9);
        Console.WriteLine("Final output::" + Output1);
        int Output2 = RecursionMethods.CountDigitOne_WoRec(99);
        Console.WriteLine("Final output::" + Output2);
        int Output3 = RecursionMethods.CountDigitOne_WoRec(999);
        Console.WriteLine("Final output::" + Output3);
        int Output4 = RecursionMethods.CountDigitOne_WoRec(1);
        Console.WriteLine("Final output::" + Output4);
        int Output5 = RecursionMethods.CountDigitOne_WoRec(1471);
        Console.WriteLine("Final output::" + Output5);


        RecursionMethods.PrintSumlSubSeq(0, new List<int>(), 0);
        RecursionMethods.PrintAllSubSeq(0, new List<int>());

        //RecursionMethods.ReverseArray(0, 9);
        long Value = RecursionMethods.Fibonacci_SingleRec(5);
        int Inp = 5;
        Console.WriteLine($"Parameter. Input:{Inp}");
        RecursionMethods.Function_SumnNumbers_Parameter(Inp, 0);
        //Console.WriteLine($"Functional. Input:{Inp}");
        //Console.WriteLine(RecursionMethods.Function_SumnNumbers_Functional(Inp));

        Console.WriteLine("Basic itr using recursion");
        RecursionMethods.BasicPrint_Recursion(5);
        Console.WriteLine("Fibo Resursion method");

        RecursionMethods.Fibonacci_MultiRecursion(10);
        Console.WriteLine("Mem");
        FAProblems.Fibonacci_Mem(10);
        Strings.MinimumDeleteSum("delete", "leet");

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
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    public class Program
    {
        //static Program()
        //{
        //    Rec();
        //}

        //static void Rec()
        //{
        //    Rec();
        //}


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //SortList(new List<int>() { 1, 2, 4, 7, 15 }, new List<int>() { 3, 5, 9 });
        }
        //Use case 1
        //arr1 [1,2,4,7,7,15,21]
        //arr2 [3,5,7,9,200]



        public static void SortList(List<int> inp1, List<int> inp2)
        {
            List<int> Final = new List<int>();
            int inp1Itr = 0, inp2Itr = 0;
            for (inp1Itr = 0; inp1Itr < inp1.Count; inp1Itr++, inp2Itr++)
            {
                if (inp1[inp1Itr] < inp2[inp2Itr])
                {
                    Final.Add(inp1[inp1Itr]);
                    Final.Add(inp2[inp2Itr]);
                }
                else if (inp1[inp1Itr] > inp2[inp2Itr])
                {
                    Final.Add(inp2[inp2Itr]);
                    Final.Add(inp1[inp1Itr]);
                }
                else
                {
                    Final.Add(inp1[inp1Itr]);
                    Final.Add(inp1[inp1Itr]);
                }
            }


        }

        //Input: Two sorted array
        //Output: Merge the two sorted arrays

        //Use case 1
        //arr1 [1,2,4,7,15]
        //arr2 [3,5,9]

        //Use case 2
        //arr1 [4,5,6]
        //arr2 [1,2]

        //Use case 3
        //arr1[1,2,3]
        //arr2[4,5,6]

        //Two for loops
        // - To iterate arr1 and arr2

        //arr1[i]<arr2[j]
        //Final.Add(arr1[i])
        //Final.Add(arr2[j])

        //arr1[i]>arr2[j]


        //arr1[i]==arr[j]
        //Add arr1[i] two times in final array

        //i++ and j++

        //Final[] : Length arr[1] and arr[2]


    }
}

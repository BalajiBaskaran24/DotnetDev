namespace DSAndAlgoReference.SampleProblems.Arrays.OneDArray
{
    public class ArraySorting
    {
        public ArraySorting() { }

        /// <summary>
        /// Input: Array with 0s,1s and 2s
        /// Output: Sorted array of 0s, 1s and 2s 
        /// Index 0 to Low-1 is 0s
        /// Low to Mid-1 is 1s
        /// High+1 to n-1 is 2s
        /// </summary>
        /// <param name="arr"></param>
        public void ArraySort(int[] arr)
        {
            int low = 0, mid = 0, high = arr.Length - 1;//3 pointers

            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    int temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
            }
        }
    }
}

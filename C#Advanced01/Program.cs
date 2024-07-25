using System;

namespace C_Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (1)
            /*
                 *(1).The Bubble Sort algorithm has a time complexity of O(n^2) in 
                its worst and average cases, which makes it inefficient for 
                large datasets. How we can optimize the Bubble Sort algorithm
                And implement the code of this optimized bubble sort algorithm
                */
            // We Can Break if is no swap will happen and the array is sorted
            //int[] arr = new int[6];
            //bool swapped;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    swapped = false;
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {

            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //            swapped = true;
            //        }
            //    }

            //    // If no two elements were swapped by inner loop => break
            //    if (!swapped)
            //        break;
            //}

            #endregion

            #region (2)

            MyRange<int> myRange = new MyRange<int> (5,16);
            MyRange<int> myRange2 = new MyRange<int>(6, 13);

            Console.WriteLine(myRange.IsInRange(17)); // False

            Console.WriteLine(myRange.Length());  // 11

            Console.WriteLine(myRange.CompareTo(myRange2)); // 1 



            #endregion
        }
    }
}

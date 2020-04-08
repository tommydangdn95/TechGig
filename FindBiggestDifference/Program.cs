using System;

namespace FindBiggestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 29, 79, 72, 81, 9, 7, 21 };
            Console.WriteLine(FindDiff(arr));
        }

        private static int FindDiff(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }

            return max - min;
        }
    }
}

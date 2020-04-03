using System;

namespace ThirdLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var inputArr = Console.ReadLine().Split(' ');
            int[] arr = new int[length]; 
            for(int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }
            int third = FindThirdLargestNumber(arr);
            Console.WriteLine(third);
        }

        private static int FindThirdLargestNumber(int[] array)
        {
            int first, second ,third;
            first = second = third = array[0];
            for (int i=0;i< array.Length; i++)
            {
                if(array[i] > first)
                {
                    third = second;
                    second = first;
                    first = array[i];
                }
                else if(array[i] > second)
                {
                    third = second;
                    second = array[i];
                }
                else
                {
                    third = array[i];
                }
            }

            return third;
        }
    }
}

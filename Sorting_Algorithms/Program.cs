using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void PrintArray(int[] array, string message)
        {
            Console.WriteLine($"{message}");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] Swap(int[] array, int m, int n)
        {
            int temp = array[m];
            array[m] = array[n];
            array[n] = temp;

            return array;
        }

        //Answer to quiz
        static int FindSmallestElement(int[] array, int startIdx)
        {
            int smallest = startIdx;
            for (int idx = startIdx + 1; idx < array.Length; idx++)
            {
                if (array[idx] < array[smallest])
                {
                    smallest = idx;
                }
            }
            return smallest;
        }


        //Answer to quiz
        static int[] SelectionSort(int[] array)
        {
            int N = array.Length;
            for (int i = 0; i < N - 1; i++)
            {
                int smallestIdx = FindSmallestElement(array, i);
                if (i != smallestIdx)
                {
                    array = Swap(array, i, smallestIdx);
                }
            }
            return array;
        }


        static int[] BubbleSort(int[] array)
        {
            int i, j;
            int N = array.Length;
            for (i = N - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array = Swap(array, j, j + 1);
                    }
                }
            }
            return array;
        }

        
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 0, 1, 2, 3, 4 };
            PrintArray(numbers, "Newly Created Array:");
            Console.WriteLine();
            numbers = Swap(numbers, 0, 2);
            PrintArray(numbers, "Swapped Array:");
            */

            
            int[] numbers = { 4, 3, 5, 7, 1 };
            PrintArray(numbers, "Unsorted Array:");
            Console.WriteLine();
            numbers = SelectionSort(numbers);
            //numbers = BubbleSort(numbers);
            PrintArray(numbers, "Sorted Array:");
            
        }
    }
}

using System;

namespace Searching_Algorithms
{
    class Program
    {
        //Answer to quiz
        static int BinarySearch(int[] array, int value)
        {
            int lowerBound = 0;
            int upperBound = array.Length - 1;
            int midPoint;

            while (lowerBound <= upperBound)
            {
                midPoint = (lowerBound + upperBound) / 2;
                if (value < array[midPoint])
                {
                    upperBound = midPoint - 1;
                }
                else if (value > array[midPoint])
                {
                    lowerBound = midPoint + 1;
                }
                else return midPoint;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 0, 10, 25, 37, 41, 5, 8 };


            Console.Write("Enter a number and the algorithm will search for it: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Array.Sort(numbers);
            int answer = BinarySearch(numbers, targetNumber);

            if (answer != -1)
                Console.WriteLine($"The number {numbers[answer]} exists at index {answer} of the sorted array.");
            else
                Console.WriteLine($"That number is not in the array.");

            Console.Write("Array: ");
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}


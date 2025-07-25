using System;
using System.Collections.Generic;

namespace Basic_Data_Structures
{
    class Program
    {
        static void ReverseArray(int[] array)
        {
            int[] passed_array = array;
            Array.Reverse(passed_array);
            for (int i = 0; i < passed_array.Length; i++)
            {
                Console.Write($"{passed_array[i]} ");
            }
        }

        static void CreateArray()
        {
            int length = 5;
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} number to place in new array: ");
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Current Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} at index {i}");
            }

            Console.WriteLine("Array in reverse order is: ");
            ReverseArray(array);
        }

        static void CreateList()
        {
            List<string> groceries = new List<string>();
            groceries.Add("apples");
            groceries.Add("bananas");
            Console.WriteLine($"Groceries total: {groceries.Count}");
            for (int i = 0; i < groceries.Count; i++)
            {
                Console.WriteLine(groceries[i]);
            }

            List<string> todo = new List<string>();
            Console.WriteLine("Add an item to your todo list: ");
            string item1 = Console.ReadLine();
            Console.WriteLine("Add an another item to your todo list: ");
            string item2 = Console.ReadLine();
            todo.Add(item1);
            todo.Add(item2);
            Console.WriteLine($"To Do List count: {todo.Count}");

            todo.AddRange(groceries);
            Console.WriteLine($"To Do List plus Groceries count: {todo.Count}");
            foreach (string item in todo)
            {
                Console.WriteLine(item);
            }

        }

        static void Main(string[] args)
        {
            CreateArray();
            CreateList();
        }
    }
}

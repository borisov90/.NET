using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stringArraySort
{
    class arraySort
    {
        // You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


        static void Main(string[] args)
        {
            string[] arr = { "asdb", "asd", "afdsa", "as" };
            string keeper = "";
            keeper = DoSorting(arr, keeper);
            PrintSortedArray(arr);
        }

        private static string DoSorting(string[] arr, string keeper)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i].Length > arr[j + 1].Length)
                    {
                        keeper = arr[i];
                        arr[i] = arr[j + 1];
                        arr[j + 1] = keeper;
                    }
                }

            }
            return keeper;
        }

        private static void PrintSortedArray(string[] arr)
        {
            Console.Write("The sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.Write(arr[i] + "!");
                }
            }
            Console.WriteLine();
        }
    }
}

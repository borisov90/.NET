using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GenerateVariations
{
    class GenerateVariations
    {
        //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	    //N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[K];
            int index = 0;
            Generate(array, index, N);
        }
        static void Generate(int[] array, int index, int length)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 1; i <= length; i++)
                {
                    array[index] = i;
                    Generate(array, index + 1, length);
                }
            }
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

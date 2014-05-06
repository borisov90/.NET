using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] elements = new int[N];
        int temp;
        List<int> arrangaedelements = new List<int>();
        for (int i = 0; i < N; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < elements.Length - 1; i++)
        {

            for (int j = 0; j < elements.Length - 1; j++)
            {
                if (elements[j] < elements[j+1] )
                {
                    continue;
                }
                else
                {
                    temp = elements[j];
                    elements[j] = elements[j + 1];
                    elements[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine(elements[i]);
        }
    }
}


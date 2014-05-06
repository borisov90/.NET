using System;
using System.Collections.Generic;

class KElementsInArrayN
{
    static void Main(string[] args)
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.

        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());
        int[] elements = new int[N];
        List<int> membersofelements = new List<int>();
        int currentmax = 0;
        Console.WriteLine("Enter N ammount of elements:");
        for (int i = 0; i < N; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < K; i++)
        {
            for (int j = N-1; j >= 0; j--)
            {
                if (elements[j] > currentmax)
                {
                    currentmax = elements[j];
                    elements[j] = 0;
                }
            }
            membersofelements.Add(currentmax);
            currentmax = 0;
        }
        int maxsum = 0;
        Console.WriteLine(new string('-', 20));
        for (int i = 0; i < K; i++)
        {
            membersofelements.Sort();
            Console.Write(membersofelements[i] + " ");
            maxsum += membersofelements[i];
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("The sum of those {0} elements is {1}", K, maxsum);

    }
}


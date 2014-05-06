using System;

class MaximalSumInArray
{
    static void Main(string[] args)
    {
        //Write a program that finds the sequence of maximal sum in given array. Example:
	    //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

        Console.WriteLine("Enter length:");
        int length = int.Parse(Console.ReadLine());
        int[] elemets = new int[length];
        for (int i = 0; i < elemets.Length; i++)
        {
            elemets[i] = int.Parse(Console.ReadLine());
        }
        int start = 0;
        int end = 0;
        int tempstart = 0;
        
        int max = elemets[0];
        int tempmax = elemets[0];

        // Kadane's algorithm

        for (int i = 1; i < elemets.Length; i++)
        {
            if (tempmax < 0)
            {
                tempmax = elemets[i];
                tempstart = i;
            }
            else
            {
                tempmax += elemets[i];
            }
            if (tempmax >= max)
            {
                max = tempmax;
                start = tempstart;
                end = i;
            }
        }
        Console.WriteLine("Max sum: {0}", max);
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(elemets[i]);
        }
    }
}


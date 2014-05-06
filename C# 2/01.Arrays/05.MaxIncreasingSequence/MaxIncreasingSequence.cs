using System;
using System.Collections.Generic;

class MaxIncreasingSequence
{
    static void Main(string[] args)
    {
       // Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
       // int[] alphasequence = {3, 2, 3, 4, 2, 2, 4 };

        int n = int.Parse(Console.ReadLine());
        int[] alphasequence = new int[n];
        for (int i = 0; i < alphasequence.Length; i++)
        {
            alphasequence[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        int longeststreak = 1;
        int start = 0;
       
        List<int> longestSequence = new List<int>();

        for (int i = 0; i < alphasequence.Length - 1; i++)
        {
            
            if (alphasequence[i+1] > alphasequence[i])
            {
                longestSequence.Add(alphasequence[i + 1]);
                counter++;
                if ((counter == 2) && (counter > longeststreak))
	            {
                    start = alphasequence[i];
	            }
                if (counter > longeststreak)
                {
                    longeststreak = counter;
                }
            }
            else if (alphasequence[i+1] < alphasequence[i])
            {
                counter = 1;
            }
           
        }
        Console.Write(start + " ");
        for (int i = 0; i < longeststreak-1; i++)
        {
            Console.Write(longestSequence[i] + " ");
        }
    }
}

// za 20 i 21 - kombinatorika da procheta :x
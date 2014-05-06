using System;


class MaximalSequenceInArray
{
    static void Main(string[] args)
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
		//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

        //makes the boom :x

        Console.WriteLine("Enter length");
        int length = int.Parse(Console.ReadLine());
        int[] sequence = new int[length];
        int counter = 1;
        int value = 0;
        int longestsequence = 1;

        Console.WriteLine("Fill in the matrix with {0} elemens", length);
        for (int i = 0; i < length; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }
        //Array.Sort(sequence);
        for (int i = 0; i < length-1; i++)
        {
            if ((sequence[i] == sequence[i+1]))
            {
                counter++;
                if (counter > longestsequence)
                {
                    longestsequence = counter;
                    value = sequence[i];
                } 
                
            }
        }
        //int[] answer = new int[tempcounter];
        for (int i = 0; i < longestsequence; i++)
        {
            Console.Write(value + " ");
        }
    }
}


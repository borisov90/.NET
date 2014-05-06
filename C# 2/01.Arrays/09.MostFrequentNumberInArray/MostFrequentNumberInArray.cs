using System;

class MostFrequentNumberInArray
{
    static void Main(string[] args)
    {
        // Write a program that finds the most frequent number in an array. Example:
	    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
        int length = int.Parse(Console.ReadLine());
        int[] elements = new int[length];
        int counter = 0;
        int mostfrequent = 0;
        int frequency = 0;
        for (int i = 0; i < length; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                if (elements[i] == elements[j])
                {
                    counter++;
                }
            }
            if (counter > frequency)
            {
                frequency = counter;
                mostfrequent = elements[i];
            }
            counter = 0;
        }
        Console.WriteLine("The most frequent number is {0} and it's frequency is {1}", mostfrequent, frequency);
    }
}

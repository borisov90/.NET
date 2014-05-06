using System;

class NSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of values that you want to sort:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the values:");
        int[] array = new int [n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Console.WriteLine("Minimal value is: {0}, and the maximum value is {1}", array[0], array[array.Length - 1]);

    }
}

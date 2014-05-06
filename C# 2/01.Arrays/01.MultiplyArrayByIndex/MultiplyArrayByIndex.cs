using System;


class MultiplyArrayByIndex
{
    static void Main(string[] args)
    {
        // Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        // Print the obtained array on the console.

        int length = 20;
        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            numbers[i] = i * 5;
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        // way to print strings !!

        Console.WriteLine(string.Join(", ", numbers));


    }
}


using System;


class CompareTwoArrays
{
    static void Main(string[] args)
    {
        //Write a program that reads two arrays from the console and compares them element by element.

        Console.WriteLine("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[length];
        int[] arrayTwo = new int[length];
        bool isEqual = true;
        Console.WriteLine("Fill in array number one: ");
        for (int i = 0; i < length; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Fill in the second array: ");
        for (int j = 0; j < length; j++)
        {
            arrayTwo[j] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < length; k++)
        {
            if (arrayTwo[k] != arrayOne[k])
            {
                isEqual = false;
            }
        }
        if (isEqual == true)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrays are different");
        }
    }
}


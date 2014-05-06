using System;

class BiggerThanK
{
    static void Main(string[] args)
    {
        // Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        int[] elements = new int[N];
        Console.WriteLine("Fill in the numbers now:");
        for (int i = 0; i < N; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(elements);
        int index = Array.BinarySearch(elements, K);
       
        while (index < 0)
	    {
            if (K < elements[0])
            {
                break;
            }
            K--;
            index = Array.BinarySearch(elements, K);
	    }
        if (index < 0)
        {
            Console.WriteLine("not found");
        }
        else
        {
            Console.WriteLine("Index: {0}, value: {1}", index, elements[index]);
        }
    }
}


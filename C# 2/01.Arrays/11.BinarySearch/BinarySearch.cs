using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        // Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

        Console.WriteLine("Enter key: ");
        int key = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter length for the array");
        int length = int.Parse(Console.ReadLine());
        int[] elements = new int[length];
        Console.WriteLine("Enter elements: ");
        for (int i = 0; i < length; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(elements);
        int maxvalue = elements.Length - 1;
        
        int minvalue = elements[0];
        int mid = 0;

        // binary search implementation

        while (minvalue < maxvalue)
        {
            mid = (minvalue + maxvalue) / 2;
           
            if (elements[mid] < key)
	        {
                minvalue = mid + 1;
	        }
            else
            {
                maxvalue = mid;
            }
            if ((maxvalue == minvalue) && (elements[minvalue] == key))
            {
                Console.WriteLine("The element {0} is at position {1}", key, minvalue);
            }
            else if((maxvalue == minvalue) && (elements[minvalue] != key))
            {
                Console.WriteLine("Doesn't exist in the array");
            }
        }
    }
}


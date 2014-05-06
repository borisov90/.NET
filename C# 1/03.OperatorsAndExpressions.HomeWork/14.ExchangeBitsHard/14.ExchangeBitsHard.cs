using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1500;
        int p = 2;
        int q = 4;
        int k = 2;

        int[] newArray = new int[32];
        for (int i = 0; i < newArray.Length; i++)
        {
            if (number == 0)
            {
                break;
            }
            newArray[i] = number % 2;
            number = number / 2;
        }
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            int result = 0;
            result = newArray[p];
            newArray[p] = newArray[q];
            newArray[q] = result;
            q++;
            p++;
        }
        Array.Reverse(newArray);
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i]);
        }
        Console.WriteLine();
    }
}


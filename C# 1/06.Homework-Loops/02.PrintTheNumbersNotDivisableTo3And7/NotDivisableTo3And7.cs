using System;
class NotDivisableTo3And7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i % 3 != 0 & i % 7 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}


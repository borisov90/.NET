using System;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value:");
        int N = int.Parse(Console.ReadLine());
        int zeroes = 0;
        int divisor = 5;

        while (N / divisor >= 1)
        {
            zeroes = zeroes + (N / divisor);
            divisor *= 5;
        }
        Console.WriteLine(zeroes);
    }
}


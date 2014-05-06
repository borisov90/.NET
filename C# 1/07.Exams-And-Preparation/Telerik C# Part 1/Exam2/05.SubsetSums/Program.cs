using System;

class Program
{
    static void Main(string[] args)
    {
        long wantedsum = long.Parse(Console.ReadLine());
        long numberofelements = long.Parse(Console.ReadLine());
        long[] elements = new long[numberofelements];
        int counter = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = long.Parse(Console.ReadLine());
        }
        int maxi = (int)Math.Pow(2, numberofelements);
        for (int i = 1; i < maxi; i++)
        {
            long currentsum = 0;
            for (int j = 0; j < elements.Length; j++)
            {
                int mask = 1 << j;
                int iandmask = i & mask;
                int bit = iandmask >> j;

                if (bit == 1)
                {
                    currentsum = currentsum + elements[j];
                }
            }
            if (currentsum == wantedsum)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}


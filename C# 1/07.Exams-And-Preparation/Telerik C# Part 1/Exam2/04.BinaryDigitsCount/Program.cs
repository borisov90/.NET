using System;

class Program
{
    static void Main(string[] args)
    {
        byte B = byte.Parse(Console.ReadLine());
        short N = short.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            int n = 0;
            ulong number = ulong.Parse(Console.ReadLine());
            while (number != 0)
            {
                if ((number & 1) == B)
                {
                    n++;
                }
                number = number >> 1;
            }
            Console.WriteLine(n);
        }
    }
}


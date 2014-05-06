using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width = (2 * n) - 1;

        for (int i = 0; i < n; i++)
        {
            string dotsStart = new string('.', i);
            string dotsEnd = new string('.',(n - i) - 1);
            Console.Write(dotsStart);
            Console.Write("*");
            Console.Write(dotsEnd);
            Console.WriteLine();
        }
        for (int i = 1; i < n; i++)
        {
            string dots2 = new string('.', n - i - 1);
            string dotsend2 = new string('.', i);
            Console.Write(dots2);
            Console.Write("*");
            Console.Write(dotsend2);
            Console.WriteLine();
        }
        
    }
}


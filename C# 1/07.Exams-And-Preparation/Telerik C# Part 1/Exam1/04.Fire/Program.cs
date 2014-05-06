using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int counter = 0;

        string dots = new string('.', N/2 -1);
        Console.Write(dots);
        Console.Write("##");
        Console.Write(dots);
        Console.WriteLine();
        for (int i = 1; i < N/2; i++)
        {
            string dotsstart = new string('.', N/2 - 1 - i);
            string dotsmiddle = new string('.', 2 + counter);
            Console.Write(dotsstart);
            Console.Write("#");
            Console.Write(dotsmiddle);
            Console.Write("#");
            Console.Write(dotsstart);
            Console.WriteLine();
            counter = counter + 2;
        }
        for (int i = N/2; i > N/4; i--)
        {
            string dotsmiddle2 = new string('.', counter);
            string dotsstart2 = new string('.', ((N - counter) - 2)/2);
            Console.Write(dotsstart2);
            Console.Write("#");
            Console.Write(dotsmiddle2);
            Console.Write("#");
            Console.Write(dotsstart2);
            Console.WriteLine();
            counter = counter - 2;
        }
        string separator = new string('-', N);
        Console.Write(separator);
        Console.WriteLine();
        for (int i = 0; i < N/2; i++)
        {
            string leftslash = new string('\\',N/2 - i );
            string rightslash = new string('/',N/2 - i);
            string finaldots = new string('.', i);
            Console.Write(finaldots);
            Console.Write(leftslash);
            Console.Write(rightslash);
            Console.Write(finaldots);
            Console.WriteLine();
        }
    }
}


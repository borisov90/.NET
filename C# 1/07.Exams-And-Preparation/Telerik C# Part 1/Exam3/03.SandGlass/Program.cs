using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < (n + 1)/2; i++)
        {
            string dots = new string('.', i);
            Console.Write(dots);
            string asterisk = new string('*', n - i  - counter);
            Console.Write(asterisk);
            Console.Write(dots);
            Console.WriteLine();
            counter++;
        }

        counter = 3;

        for (int i = (n)/2; i > 0; i--)
        {
            string dots = new string('.', (n - counter)/2);
            string asterisk = new string('*', counter);
            Console.Write(dots);
            Console.Write(asterisk);
            Console.Write(dots);
            Console.WriteLine();
            counter += 2;
            
        }
    }
}


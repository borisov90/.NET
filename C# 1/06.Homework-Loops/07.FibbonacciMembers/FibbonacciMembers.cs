using System;

class FibbonacciMembers
{
    static void Main(string[] args)
    {
        double a = 0, b = 1, n, c, i;
        Console.WriteLine("Enter number for Fibonacci sequence");
        n = double.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci sequence is:");
        Console.WriteLine("" + a);
        Console.WriteLine("" + b);
        double temp = 0;

        for (i = 1; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine("" + c);
            temp += c;
            
        }
        Console.WriteLine("The sum of the Fibonacci sequence to the {0}th member is {1}",n ,temp+1);
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position");
        int numberB = int.Parse(Console.ReadLine());
        int mask = 1 << numberB;
        string n = Convert.ToString(i, 2);
        Console.WriteLine(n);

        if (((i & mask) >> numberB) == 0)
        {
            Console.WriteLine("The value of the bit in position {0} is 0.", numberB);
        }
        else
        {
            Console.WriteLine("The value of the bit in position {0} is 1.", numberB);
        }
    }
}


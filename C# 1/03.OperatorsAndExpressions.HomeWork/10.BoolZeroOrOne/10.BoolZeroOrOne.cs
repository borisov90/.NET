using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number v:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        bool isOne;

        string n = Convert.ToString(v, 2);
        Convert.ToInt32(n, 2);

        Console.WriteLine(n);

        if (((v | mask) >> p) == 1)
        {
            isOne = true;
            Console.WriteLine("The number in position {0} is 1 - {1}.", p, isOne);
        }
        else
        {
            isOne = false;
            Console.WriteLine("The number in position {0} is 1 - {1}.", p, isOne);
        }
    }
}

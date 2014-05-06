using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        bool isEven;

        if (n % 2 == 0)
        {
            isEven = true;
        }
        else isEven = false;
        Console.WriteLine("Is it even? {0 }", isEven);
    }
}


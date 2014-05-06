using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        string newNumber = Convert.ToString(number, 2);
        Convert.ToInt32(newNumber, 2);

        bool isThree;
        int mask = (1 << 3);

        if (((number | mask) >> 3) == 1)
        {
            isThree = true;
            Console.WriteLine("The third bit is 1  - {0}", isThree);
            Console.WriteLine(newNumber);
            return;
        }
        else isThree = false;
        Console.WriteLine("The third bit is 1  - {0}", isThree);
        Console.WriteLine(newNumber);
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value to be set (1 ot 0):");
        byte value = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter position to be set:");
        byte position = byte.Parse(Console.ReadLine());
        int mask = 1 << position;

        string n = Convert.ToString(number, 2);


        if (value == 1)
        {
            Console.WriteLine("The number {0} in binary is {1}", number, n);
            int newNumber = ((number | mask));
            string newBinary = Convert.ToString(newNumber, 2);
            Console.WriteLine("The new value is {0} ", newBinary);
            Console.WriteLine("To the number is added value {0} at position {1}", value, position);
        }

    }
}


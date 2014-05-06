using System;

class Program
{
    static void Main(string[] args)
    {
        uint number = 1500;
        uint mask = 7;

        Console.WriteLine("The starting number is {0}", Convert.ToString(number, 2));

        uint firstThreeBits = number & (mask << 3);
        uint secondThreeBits = number & (mask << 24);

        firstThreeBits = firstThreeBits << 21;
        secondThreeBits = secondThreeBits >> 21;

        number = number & (~(mask << 3));
        number = number & (~(mask << 24));
            
        number = number | firstThreeBits;
        number = number | secondThreeBits;
        Console.WriteLine("The final number is {0}",Convert.ToString(number, 2));

    }
}


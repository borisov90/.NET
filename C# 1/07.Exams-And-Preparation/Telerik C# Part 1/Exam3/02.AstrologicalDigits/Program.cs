using System;

class Program
{
    static void Main(string[] args)
    {
        int sumdigits = 0;
        while (true)
        {
            int ch = Console.Read();
            if (ch == -1 || ch == '\r' || ch == '\n')
            {
                break;
            }
            if (ch >= '0' && ch <= '9')
            {
                 char nextchar = (char)ch;
                 int digit = nextchar - '0';
            // int digit = int.Parse(nextchar.ToString()); another way of moving from char to int.
                 sumdigits += digit;
            }
        }
        while (sumdigits > 9)
        {
            int finalsum = 0;
            while (sumdigits > 0)
            {
                int lastdigit = sumdigits % 10;
                finalsum += lastdigit;
                sumdigits = sumdigits / 10;
            }
            sumdigits = finalsum;
        }
        Console.WriteLine(sumdigits);
    }
}


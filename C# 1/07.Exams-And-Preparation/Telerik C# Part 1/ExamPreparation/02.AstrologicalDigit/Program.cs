using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int digitsum = 0;
        
        while (true)
        {
            int ch = Console.Read();
            if (ch == - 1 || ch == '\n' || ch == '\r')
            {
                break;
            }
            if (ch >= '0' && ch <= '9')
            {
                char nextchar = (char)(ch);
                int digitise = (int)(nextchar - '0');
                digitsum = digitsum + digitise;
            }
        }
        while (digitsum > 9)
        {
              int finalsum = 0;
              while (digitsum > 0)
            {
                int digit = digitsum % 10;
                digitsum = digitsum / 10;
                finalsum = finalsum + digit;
            }
            digitsum = finalsum;
        }
        Console.WriteLine(digitsum);
    }
}


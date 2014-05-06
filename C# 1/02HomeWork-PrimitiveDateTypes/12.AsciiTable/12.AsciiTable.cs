using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 0; i < 256; i++)
        {
            char c = (char)i;
            Console.WriteLine("The ASCII representation of {0} is {1}", i, c);
        }
    }
}
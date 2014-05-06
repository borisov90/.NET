using System;

class Program
{
    static void Main(string[] args)
    {
        string i = @"The ""use"" of quotations causes difficulties";
        string b = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(i);
        Console.WriteLine(b);
    }
}


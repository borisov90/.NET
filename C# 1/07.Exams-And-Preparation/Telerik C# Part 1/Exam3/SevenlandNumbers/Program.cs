using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int inputnumber = int.Parse(input);
        byte powerCounter = 0;
        int decimalnumber = 0;
        while (inputnumber != 0)
        {
            byte lastNumber = (byte)(inputnumber % 10);
            decimalnumber += lastNumber * (int)Math.Pow(7, powerCounter);
            powerCounter++;
            inputnumber /= 10;
        }
        decimalnumber++;
        string result = "";
        while (decimalnumber != 0)
        {
            byte lastNumber = (byte)(decimalnumber % 7);
            result = lastNumber + result;
            decimalnumber /= 7;
        }
        Console.WriteLine(result);
    }
}


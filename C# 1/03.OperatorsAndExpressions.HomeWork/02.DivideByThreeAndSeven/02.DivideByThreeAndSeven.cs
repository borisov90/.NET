using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Divide by 3 and 7";

        Console.WriteLine("Enter number");
        int i = int.Parse(Console.ReadLine());
        bool isDivided;

        if (i % 5 == 0 && i % 7 == 0)
        {
            isDivided = true;
            Console.WriteLine("This number can be devided by 5 and 7");
            return;
        }
        isDivided = false;
        Console.WriteLine("This number can not be devided by 5 and 7");
    }
}


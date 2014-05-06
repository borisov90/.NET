using System;

class Program
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime Value = new DateTime(year, month, day);
        Value = Value.AddDays(1);
        Console.WriteLine(Value.ToString("d.M.yyyy"));
    }
}


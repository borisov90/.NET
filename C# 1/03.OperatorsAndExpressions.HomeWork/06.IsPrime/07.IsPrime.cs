using System;

class Program
{
static void Main(string[] args)
  {
    Console.Title = "Prime number identifier";

    Console.WriteLine("Enter number to be identified (up to 100): ");
    int n = int.Parse(Console.ReadLine());

    if (n == 1 || n == 0)
    {
        Console.WriteLine("{0} is not a prime number", n);
        return;
    }
    else if (n == 3 | n == 5 | n == 7 | n == 11 | n == 13 | n == 17 | n == 19)
    {
        Console.WriteLine("{0} is a prime number", n);
    }
    else if (n % 2 == 0 | n % 3 == 0 | n % 5 == 0 | n % 7 == 0)
    {
        Console.WriteLine("{0} is not a prime number", n);
    }
  }
}

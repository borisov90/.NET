using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number to end the counting to: ");
        int n = int.Parse(Console.ReadLine()) ;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "\n");
            }
        }
        else
        {
            Console.WriteLine("Error. The number you have entered is invalid.");
        }
       
    }
}


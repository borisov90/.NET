using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int n2 = n;
        //if you don't want to include the first number 'n' with the sum of the other numbers, change n2 to be equal to zero!!

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter new number:");
            int n1 = int.Parse(Console.ReadLine());
            n2 = n2 + n1;
        }
       
        Console.WriteLine("The sum of all of those numbers is {0}", n2);
    }
}


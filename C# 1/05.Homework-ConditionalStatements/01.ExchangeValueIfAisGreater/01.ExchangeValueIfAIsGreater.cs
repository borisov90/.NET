using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for integer b");
        int b = int.Parse(Console.ReadLine());
        
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Integer a was greater than b, and that's why we exchange their values and now a is {0} and b is {1}", a , b);
        }
        else 
        {
            Console.WriteLine("Integer a = {0}, is smaller than b = {1}", a, b);
        }
    }
}


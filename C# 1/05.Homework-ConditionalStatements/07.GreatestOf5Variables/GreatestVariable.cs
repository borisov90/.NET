using System;
using System.Linq;

class GreatestVariable
{
    static void Main(string[] args)
    {
      //  Write a program that finds the greatest of given 5 variables.
      
       int a = int.Parse(Console.ReadLine());
       int b = int.Parse(Console.ReadLine()); 
       int c = int.Parse(Console.ReadLine()); 
       int d = int.Parse(Console.ReadLine()); 
       int e = int.Parse(Console.ReadLine()); 
       
       //int[] fiveNumbers = new int[]{ a, b, c, d, e};
       //int maxNumber = fiveNumbers.Max();
       //Console.WriteLine("The greatest number is: {0}", maxNumber); <-- That's another way of solving this

      int check = a;
        if (check < b)
        {
            check = b;
        }
        if (check < c)
        {
            check = c;
        }
        if (check < d)
        {
            check = d;
        }
        if (check < e)
        {
            check = e;
        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(check);
        Console.WriteLine(new string('-', 40));
      
      
    }
}


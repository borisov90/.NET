using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        int maxvalue = 10000000;
        int value = (int)Math.Sqrt(maxvalue);
        Console.WriteLine(value);
        bool[] array = new bool[maxvalue];

        for (int i = 2; i < maxvalue; i++)
        {
            array[i] = true;
        }
        for (int i = 2; i < maxvalue; i++)
        {
            if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
            {
                array[i] = false;
                // sets the numbers that are not prime
            }
        }
       
        for (int i = 0; i < maxvalue; i++)
        {
            if (array[i] == true)
            {
                Console.Write(i + " ");
                //prints the index of the prime numbers
            }
        }
    }
}


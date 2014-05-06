using System;

class PrintAMarix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive integer (smaller than 20): ");
        int N = int.Parse(Console.ReadLine());

        int rows = N;
        int columns = N+1;

        int[,] Matrix = new int[rows,columns];

        for ( rows = 0; rows < Matrix.GetLength(0); rows++)
        {
            for (columns = 1; columns < Matrix.GetLength(1); columns++)
            {
                Console.Write("{0,4}",Matrix[rows,columns] = (rows + columns));

            }
            Console.WriteLine();
        }
        
    }
}


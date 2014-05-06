using System;

class FillAMatrix
{
    static void Main(string[] args)
    {
        
        int start = 1;
        int n = int.Parse(Console.ReadLine());
        int end = (int)Math.Pow(n, 2);
        int[,] matrix= new int[n, n];
        int[] array = new int[end];
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = i;
        }
        int digit = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = digit;
                digit++;
            }
            
        }
        // print matrix option A;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[col, row]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        // Option B 
        digit = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = digit;       
                    digit++;
                }
            }
        }
        // print matrix option B

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        // option C

        int counter = 1;
        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                matrix[row + col, col] = counter++;
            }
        }
        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row < n - col ; row++)
            {
                matrix[row, col + row] = counter++;
            }
        }
        Console.WriteLine();

        // print option C

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


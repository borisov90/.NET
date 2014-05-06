using System;

class RectangularMatrix
{
    static void Main(string[] args)
    {
        // declare the matrix
        Console.WriteLine("Enter number of rows");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.WriteLine("Matrix {0}, {1}", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        //int[,] matrix = 
        //{
        //    {0, 2, 4, 0, 9, 5},
        //    {7, 1, 3, 3, 2, 1},
        //    {1, 3, 9, 8, 5, 6},
        //    {4, 6, 7, 9, 1, 0},
        //};

        // finding the max platform (subset) with size 3x3;

        int maxsum = int.MinValue;
        int bestrow = 0;
        int bestcol = 0;
        int sum = 0;
        for (int row = 0; row <= matrix.GetLength(0)- 3; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1]
                    + matrix[row + 2, col] + matrix[row, col + 2] + matrix[row + 2, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    bestrow = row;
                    bestcol = col;
                }
            }
        }
        Console.WriteLine("The best 3 by 3 platform is:");
        Console.WriteLine();
        Console.WriteLine("{0}, {1}, {2}", matrix[bestrow, bestcol], matrix[bestrow, bestcol + 1], matrix[bestrow, bestcol + 2]);
        Console.WriteLine("{0}, {1}, {2}", matrix[bestrow+1, bestcol], matrix[bestrow+1, bestcol + 1], matrix[bestrow+1, bestcol + 2]);
        Console.WriteLine("{0}, {1}, {2}", matrix[bestrow + 2, bestcol], matrix[bestrow+2, bestcol + 1], matrix[bestrow +2, bestcol + 2]);

    }
}

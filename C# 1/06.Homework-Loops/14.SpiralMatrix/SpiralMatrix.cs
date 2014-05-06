using System;



class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number for the matrix: ");
        int n = int.Parse(Console.ReadLine());
        string direction = "right";
        int[,] Matrix = new int[n, n];
        int maxTurns = n * n;
        int row = 0;
        int col = 0;
        for (int i = 1; i <= maxTurns; i++)
        {
            if (direction == "right" && (col > n - 1 || Matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || Matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (col < 0 || Matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || Matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }


            Matrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,4}", Matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}


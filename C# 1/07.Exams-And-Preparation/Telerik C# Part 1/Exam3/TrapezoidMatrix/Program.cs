using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int widthtop = N;
        int height = N + 1;
        int withbottom = 2 * N;
        int[,] matrix = new int[height, withbottom];

        int currentcol = N;
        int currentrow = 0;
        while (true)
        {
            matrix[currentrow, currentcol] = 1;
            currentcol--;
            currentrow++;
            if (currentcol < 0)
            {
                break;
            }
          
        }
        while (true)
        {
            matrix[currentrow, currentcol] = 1;
            currentcol++;
            if (currentcol > withbottom)
            {
                break;
            }
        }

        //printing

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < withbottom; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}


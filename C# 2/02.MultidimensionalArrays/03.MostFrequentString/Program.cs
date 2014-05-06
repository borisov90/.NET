using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] matrix = {
                              {"oi", "ha", "de", "mu", "ni"},
                              {"oi", "mqo", "mqo", "mqo", "m"},
                              {"ol", "oi", "ha", "bau", "de"},
                              {"oh", "pa", "oi", "hack", "de"},
                              {"oh", "az", "de", "oi", "de"}
                          };
        int counter = 1;
        int bestCounter = int.MinValue;
        string element = "";
 
        //horizontal.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
 
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }
 
        //vertical.
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
 
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }
 
        //diagonal from top left to bottom right.
 
        for (int col = 0, row = 0; col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1; col++, row++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                counter++;
 
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;
 
        //diagonal from top right to bottom left.
 
        for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                counter++;
 
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;
 
        Console.WriteLine(@"The most frequent string is ""{0}"" (repeated {1} times)", element, bestCounter);
    }
}
    

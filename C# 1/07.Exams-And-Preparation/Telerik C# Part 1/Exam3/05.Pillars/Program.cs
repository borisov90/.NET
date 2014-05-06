using System;

class Program
{
    static void Main(string[] args)
    {
        // NOT WORKING CORRECTLY
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int n = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((n & (1 << col)) != 0)
                {
                    matrix[row, col] = 1;
                }
            }
        }
        int maxlength = 0;
        int count = 0;
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int length = 0;
                while (col < 8 && matrix[row, col] == 1)
                {
                     col++;
                     length++;
                }
                if (length == maxlength)
                {
                    count++;
                }
                if (length > maxlength)
	            {
		            maxlength = length;
                    count = 1;
	            }
            }
        }
        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                int length = 0;
                while (row < 8 && matrix[row, col] == 1)
                {
                    row++;
                    length++;
                }
                if (length == maxlength)
                {
                    count++;
                }
                if (length > maxlength)
                {
                    maxlength = length;
                    count = 1;
                }
            }
        }
        if (maxlength == 1)
        {
            count = count / 2;
        }
        Console.WriteLine(maxlength);
        Console.WriteLine(count);
    }
}


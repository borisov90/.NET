using System;
using System.Text;

class OperatorOverloading
{
    // * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().


    public class Matrix
    {
        private int rows;
        private int cols;
        private int[,] matrix;

        public Matrix(int x, int y)
        {
            rows = x;
            cols = y;
            matrix = new int[rows, cols];
        }

        public int this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        public int getRows()
        {
            return rows;
        }

        public int getCols()
        {
            return cols;
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
            {
                throw new Exception("Matrices must have the same dimensions!");
            }

            Matrix result = new Matrix(first.getRows(), first.getCols());

            for (int i = 0; i < first.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < second.matrix.GetLength(1); j++)
                {
                    result[i, j] = first[i, j] + second[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
            {
                throw new Exception("Matrices must have the same dimensions!");
            }

            Matrix result = new Matrix(first.getRows(), first.getCols());

            for (int i = 0; i < first.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < second.matrix.GetLength(1); j++)
                {
                    result[i, j] = first[i, j] - second[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
            {
                throw new Exception("Matrices must have the same dimensions!");
            }

            Matrix result = new Matrix(first.getRows(), first.getCols());

            for (int i = 0; i < first.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < second.matrix.GetLength(1); j++)
                {
                    result[i, j] = first[i, j] * second[i, j];
                }
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder matrixToString = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixToString.Append(String.Format("{0} ", matrix[i, j]).PadRight(4, ' '));
                }
                matrixToString.Append("\n");
            }

            return matrixToString.ToString();
        }

    }

    static void Main(string[] args)
    {
        Matrix m1 = new Matrix(4, 4);
        Matrix m2 = new Matrix(4, 4);
        Matrix result;

        //enter random data
        int counter = 1;
        for (int i = 0; i < m1.getCols(); i++)
        {
            for (int j = 0; j < m1.getRows(); j++)
            {
                m1[i, j] = counter;
                m2[i, j] = j + counter;
                counter++;
            }
        }

        //print
        Console.WriteLine(m1);
        Console.WriteLine(m2);

        result = m1 + m2;
        Console.WriteLine("Addition:");
        Console.WriteLine(result);

        result = m1 - m2;
        Console.WriteLine("Subtraction:");
        Console.WriteLine(result);

        result = m1 * m2;
        Console.WriteLine("Multiplication:");
        Console.WriteLine(result);
    }
}
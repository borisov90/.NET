/* 08
 * Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). */
/* 09
 * Implement an indexer this[row, col] to access the inner matrix cells. */
/* 10
 * Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
 * Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements). */

namespace Generics
{
    using System;
    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private const int DEFAULT_SIZE = 2;

        private T[,] matrix;
        public int rows { get; private set; }
        public int cols { get; private set; }

        public Matrix()
            : this(DEFAULT_SIZE, DEFAULT_SIZE)
        {
        }
        public Matrix(int rowSize, int colSize)
        {
            this.rows = rowSize;
            this.cols = colSize;
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] array)
        {
            this.rows = array.GetLength(0);
            this.cols = array.GetLength(1);
            this.matrix = (T[,])array.Clone();
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex >= 0 && rowIndex < this.rows
                    && colIndex >= 0 && colIndex < this.cols)
                {
                    return this.matrix[rowIndex, colIndex];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index is outside of the bounds of the array");
                }
            }
            set
            {
                if (rowIndex >= 0 && rowIndex < this.rows
                    && colIndex >= 0 && colIndex < this.cols)
                {
                    this.matrix[rowIndex, colIndex] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index is outside of the bounds of the array");
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> arg1, Matrix<T> arg2)
        {
            if ((arg1.cols != arg2.cols) || (arg1.rows != arg2.rows))
            {
                throw new ArgumentException("Matrices must have equal size");
            }
            else
            {
                T[,] tempArray = new T[arg1.rows, arg1.cols];
                for (int i = 0; i < arg1.rows; i++)
                {
                    for (int z = 0; z < arg1.cols; z++)
                    {
                        tempArray[i, z] = checked((dynamic)arg1[i, z] + (dynamic)arg2[i, z]);
                    }
                }
                return new Matrix<T>(tempArray);
            }
        }

        public static Matrix<T> operator -(Matrix<T> arg1, Matrix<T> arg2)
        {
            if ((arg1.cols != arg2.cols) || (arg1.rows != arg2.rows))
            {
                throw new ArgumentException("Matrices must have equal size");
            }
            else
            {
                T[,] tempArray = new T[arg1.rows, arg1.cols];
                for (int i = 0; i < arg1.rows; i++)
                {
                    for (int z = 0; z < arg1.cols; z++)
                    {
                        tempArray[i, z] = checked((dynamic)arg1[i, z] - (dynamic)arg2[i, z]);
                    }
                }
                return new Matrix<T>(tempArray);
            }
        }

        public static Matrix<T> operator *(Matrix<T> arg1, Matrix<T> arg2)
        {
            if ((arg1.cols != arg2.cols) || (arg1.rows != arg2.rows))
            {
                throw new ArgumentException("Matrices must have equal size");
            }
            else
            {
                T[,] tempArray = new T[arg1.rows, arg1.cols];
                for (int i = 0; i < arg1.rows; i++)
                {
                    for (int z = 0; z < arg1.cols; z++)
                    {
                        tempArray[i, z] = checked((dynamic)arg1[i, z] * (dynamic)arg2[i, z]);
                    }
                }
                return new Matrix<T>(tempArray);
            }
        }

        //Check if the matrix contains a zero-element. I'm not sure if I understood the task correctly
        public static bool operator true(Matrix<T> arg1)
        {
            for (int i = 0; i < arg1.rows; i++)
            {
                for (int z = 0; z < arg1.cols; z++)
                {
                    if (arg1[i, z].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> arg1)
        {
            for (int i = 0; i < arg1.rows; i++)
            {
                for (int z = 0; z < arg1.cols; z++)
                {
                    if (arg1[i, z].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

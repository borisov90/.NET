using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    [Version(1, 1)]
    class Program
    {
        static void PrintMatrix(Matrix<int> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int z = 0; z < matrix.cols; z++)
                {
                    Console.Write("{0} ", matrix[i, z]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            //Generic Test
            GenericList<string> test = new GenericList<string>(4);

            //add tests
            test.Add("zero");
            test.Add("one");
            test.Add("two");
            test.Add("three");

            //auto-grow test
            test.Add("four");

            //ToString() test - not sure if this is correct
            Console.WriteLine(test);

            //acess element by index test
            Console.Write("Value at index 2 : ");
            Console.WriteLine(test.Peek(2) + "\n");

            //acess element by index test - throws exception
            //Console.WriteLine(test.Peek(6));

            //insert element at given position test
            test.Insert(3, "tempThree");

            Console.WriteLine("Insert value \"tempThree\" at position 3: ");
            Console.WriteLine(test);

            //insert element at given position test - throws exception
            //test.Insert(6, "exception");

            //remove element by index test
            test.RemoveAtIndex(3);

            Console.WriteLine("Removed index 3: ");
            Console.WriteLine(test);

            //remove element by index test - throws exception
            //test.RemoveAtIndex(5);

            //find index of element by it's value test
            Console.Write("Search for the index of \"one\": ");
            Console.WriteLine(test.IndexOfElement("one") + "\n");

            Console.Write("Search for index of \"not excisting\": ");
            Console.WriteLine(test.IndexOfElement("not excisting") + "\n");

            //Min and max test
            Console.Write("Find min: ");
            Console.WriteLine(test.Min());
            Console.Write("Find max: ");
            Console.WriteLine(test.Max());

            //clear the list test
            test.ClearList();
            Console.WriteLine("List cleared " + test);
            Console.WriteLine();
            //Matrix + operator test
            int[,] testMatrix1 = {
                               {10,20,33},
                               {1,50,3}
                           };
            int[,] testMatrix2 = {
                               {3,0,3},
                               {3,3,3}
                           };

            Matrix<int> matrix1 = new Matrix<int>(testMatrix1);
            Matrix<int> matrix2 = new Matrix<int>(testMatrix2);
            matrix1 = matrix1 + matrix2;

            PrintMatrix(matrix1);

            //Matrix operator "-" test 
            //Must return the initial matrix1 values
            Console.WriteLine();
            matrix1 = matrix1 - matrix2;
            PrintMatrix(matrix1);

            //Matrix operator * test
            Console.WriteLine();
            matrix1 = matrix1 * matrix2;
            PrintMatrix(matrix1);

            //True/False operators test
            if (matrix1)
            {
                Console.WriteLine("\nDoes not contain 0!\n");
            }
            else
            {
                Console.WriteLine("\nContains 0!\n");
            }

            //Attribute test
            Type type = typeof(Program);
            object[] versions = type.GetCustomAttributes(false);
            foreach (VersionAttribute version in versions)
            {
                Console.WriteLine("Current version: {0}.{1}\n",
                    version.Major, version.Minor);
            }
            Console.ReadLine();
        }
    }
}

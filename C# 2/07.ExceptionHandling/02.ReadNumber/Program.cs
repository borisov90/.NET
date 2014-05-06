using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int[] ReadNumber(int start, int end, int[] array)
    {
        array = new int[10];
        int count = 0;
        while (count < 10)
        {
            try
            {
                Console.WriteLine("Enter number {0} please: ", count);
                array[count] = int.Parse(Console.ReadLine());
                if (array[count] <= start || array[count] >= end)
                {
                    throw new System.ArgumentException();
                }
                else
                {
                    start = array[count];
                }
               
            }
            catch (FormatException)
            {

                Console.WriteLine("This is not valid. Try again with number in the range 1 to 100");
                count--;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The number entered is outside the range 1 to 100, and smaller than the previous entered number");
                count--;
            }
           
            count++;
        }

        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        return array;
    }
    static void Main(string[] args)
    {

        int start = 1;
        int end = 100;
        int[] array = new int[10];

        ReadNumber(start, end, array);
       
    }
}


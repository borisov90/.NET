using System;



class CatchExceptionSquareRoot
{
    static long Square(string str)
    {
        long number = int.Parse(str);
        return number * number;
    }
    static void Main(string[] args)
    {
        try
        {
            string number = Console.ReadLine();
            long squarednumber = Square(number);
            Console.WriteLine("{0} squared is {1}", number, squarednumber);
            return;
        }
        catch (IndexOutOfRangeException)
        {

            Console.WriteLine("Try with smaller number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter valid number, please");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Try something easier!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}


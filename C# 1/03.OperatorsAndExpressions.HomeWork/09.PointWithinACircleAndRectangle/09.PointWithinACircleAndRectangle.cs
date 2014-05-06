using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for point x: ");
        float pointX = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for point y: ");
        float pointY = float.Parse(Console.ReadLine());
        int radius = 3;
        int centerX = 1;
        int centerY = 1;
        int rtop = 1;
        int leftSide = -1;
        int width = 6;
        int height = 2;
        int top = rtop;
        int left = leftSide;
        int right = leftSide + width;
        int bottom = top - height;

        float inCircle = ((pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY));
        bool pointWithinACircle = (inCircle < radius * radius);
        bool pointWithinARectangle = ((pointX <= top) && (pointX >= bottom) && (pointY >= left) && (pointY <= right));

        if (pointWithinARectangle && pointWithinACircle == true)
        {
            Console.WriteLine("The point with coordinates {0} and {1}, is inside the rectangle and the circle.", pointX, pointY);
        }
        else if (pointWithinACircle && !pointWithinARectangle == true)
        {
            Console.WriteLine("The point with coordinates {0} and {1}, is inside the circle and outside of the rectangle.", pointX, pointY);
        }
        else if (!pointWithinACircle && pointWithinARectangle == true)
        {
            Console.WriteLine("The point with coordinates {0} and {1}, is inside the rectangle and outside of the circle.", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The point with coordinates {0} and {1}, is outside  of the rectangle and the circle.", pointX, pointY);
        }
    }
}


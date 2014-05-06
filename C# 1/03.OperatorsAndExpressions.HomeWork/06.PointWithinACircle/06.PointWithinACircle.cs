using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for point x: ");
        float pointX = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for point y: ");
        float pointY = float.Parse(Console.ReadLine());
        float center = 0;
        float radius = 5;

        bool isInside;

        float inside = (((pointY - center) * (pointY - center) + (pointX - center) * (pointX - center)));
        if (inside < radius * radius)
        {
            isInside = true;
            Console.WriteLine("Point with coordinates x = {0} and y = {1} will be inside of the circle", pointX, pointY);
            return;
        }
        else
        {
            isInside = false;
            Console.WriteLine("Point with coordinates x = {0} and y = {1} will be outside of the circle", pointX, pointY);
        }
    }
}

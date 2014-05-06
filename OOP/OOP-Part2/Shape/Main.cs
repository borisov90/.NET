namespace Shape
{
    using System;
    using System.Collections.Generic;
    class MainMethod
    {
        static void Main()
        {
            Rectangle rect =  new Rectangle(5, 6);
            Triangle triangle = new Triangle(3, 7);
            Circle circle = new Circle(5);

            Shape[] shapes = new Shape[3] { rect, triangle, circle};

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}

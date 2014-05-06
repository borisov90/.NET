namespace Shape
{
    using System;

    class Circle : Shape
    {
        //constructor

        public Circle(double width)
            : base(width)
        {
            this.width = width;
        }

        //method

        public override double CalculateSurface()
        {
            return Math.Pow((this.width/2), 2) * Math.PI;
        }
    }
}

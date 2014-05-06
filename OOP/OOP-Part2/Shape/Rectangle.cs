namespace Shape
{
    using System;
    class Rectangle : Shape
    {
         // constructor 
        public Rectangle(double width, double height)
            : base(width, height) { }

        //method

        public override double CalculateSurface()
        {
            return this.width * this.height;
        }
    }
}

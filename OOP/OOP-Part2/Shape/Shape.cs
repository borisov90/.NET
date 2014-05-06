namespace Shape
{
    using System;

    abstract class Shape
    {
        // fields
        protected double width { get; set; }
        protected double height { get; set; }

        // construtor

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public Shape(double width)
        {
            this.width = width;
        }

        //method

        public virtual double CalculateSurface() 
        {
            return this.height * this.width;
        }
    }
}

﻿namespace Shape
{
    using System;
    class Triangle : Shape
    {
        // constructor 
        public Triangle(double width, double height)
            : base(width, height) { }

        //method

        public override double CalculateSurface()
        {
            return (this.width * this.height) / 2;
        }
    }
}

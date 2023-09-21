using System;

namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class CircleCalculator : ICalculator
    {
        private double radius;

        public CircleCalculator(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return Math.PI * 2 * radius;
        }
    }
}
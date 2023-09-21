using System;

namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class CirclePrinter : IPrinter
    {
        public CirclePrinter(int x, int y, int radius)
        {
            XOriginCoordinate = x;
            YOriginCoordinate = y;
            Radius = radius;
        }

        public int XOriginCoordinate { get; set; }

        public int YOriginCoordinate { get; set; }

        public int Radius { get; set; }

        public void PrintShapeType()
        {
            Console.WriteLine($"I print a Circle");
        }

        public void ShowOrigin()
        {
            Console.WriteLine($"I print a Circle on {XOriginCoordinate},{YOriginCoordinate} with radius={Radius}");
        }
    }
}
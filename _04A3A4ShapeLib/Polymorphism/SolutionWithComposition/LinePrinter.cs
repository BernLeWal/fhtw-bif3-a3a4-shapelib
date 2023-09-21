using System;

namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class LinePrinter : IPrinter
    {
        public LinePrinter(int x1, int y1, int x2, int y2)
        {
            XOriginCoordinate = x1;
            YOriginCoordinate = y1;
            X2 = x2;
            Y2 = y2;
        }

        public int XOriginCoordinate { get; }

        public int YOriginCoordinate { get; }

        public int X2 { get; }
        public int Y2 { get; }

        public void PrintShapeType()
        {
            Console.WriteLine($"I'm a Line");
        }

        public void ShowOrigin()
        {
            Console.WriteLine($"I'm a Line from {XOriginCoordinate},{YOriginCoordinate} to {X2},{YOriginCoordinate}");
        }
    }
}
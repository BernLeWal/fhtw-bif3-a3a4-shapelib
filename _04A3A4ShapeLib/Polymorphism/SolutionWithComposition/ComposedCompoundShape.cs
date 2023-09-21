using System;
using System.Collections.Generic;

namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class ComposedCompoundShape : IPrinter, ICalculator
    {
        private readonly List<IPrinter> _shapePrinterList = new List<IPrinter>();
        private readonly List<ICalculator> _shapeCalculatorList = new List<ICalculator>();

        public ComposedCompoundShape(int x, int y)
        {
            XOriginCoordinate = x;
            YOriginCoordinate = y;
        }

        public int XOriginCoordinate { get; }

        public int YOriginCoordinate { get; }


        public int Count => _shapePrinterList.Count;

        public void Add(ComposedShape shape)
        {
            _shapePrinterList.Add(shape);
            _shapeCalculatorList.Add(shape);
        }


        public void PrintShapeType()
        {
            Console.WriteLine("I'm a CompoundShape");
            foreach (var shape in _shapePrinterList)
            {
                shape.PrintShapeType();
            }
        }

        public void ShowOrigin()
        {
            Console.WriteLine(string.Format("Origin: {0}, {1}", XOriginCoordinate, YOriginCoordinate));
        }

        public double GetArea()
        {
            double tempArea = 0;
            foreach (var shape in _shapeCalculatorList)
            {
                tempArea += shape.GetArea();
            }
            Console.WriteLine($"Sum of all areas: {tempArea}");

            return tempArea;
        }

        public double GetPerimeter()
        {
            double tempPerimeter = 0;
            foreach (var shape in _shapeCalculatorList)
            {
                tempPerimeter += shape.GetPerimeter();
            }
            Console.WriteLine($"Sum of all perimeters: {tempPerimeter}");

            return tempPerimeter;
        }
    }
}
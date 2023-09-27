using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public abstract class ComposedShape : IPrinter, ICalculator
    {
        protected readonly IPrinter _printer;
        protected readonly ICalculator _calculator;

        protected ComposedShape(IPrinter printer, ICalculator calculator)
        {
            _printer = printer;
            _calculator = calculator;
        }

        // Delegating the implementation to the composed objects
        // IPrinter:
        public int XOriginCoordinate => _printer.XOriginCoordinate;

        public int YOriginCoordinate => _printer.YOriginCoordinate;

        public void PrintShapeType()
        {
            _printer.PrintShapeType();
        }

        public void ShowOrigin()
        {
            _printer.ShowOrigin();
        }

        // ICalculator:
        public double GetArea()
        {
            return _calculator.GetArea();
        }

        public double GetPerimeter()
        {
            return _calculator.GetPerimeter();
        }


        // A new function that uses the composed objects
        public void DoSomeFunction()
        {
            Console.WriteLine("We want to draw the shape");
            _printer.ShowOrigin();

            Console.WriteLine("Now we calc the area");
            Console.WriteLine(_calculator.GetArea());
        }

    }
}

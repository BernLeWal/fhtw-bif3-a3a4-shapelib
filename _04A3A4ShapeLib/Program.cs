using _04A3A4ShapeLib.Polymorphism.SolutionWithComposition;
using System.Threading.Channels;

namespace _04A3A4ShapeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var rect = new ComposedRect(1, 2, 3, 4);
            rect.PrintShapeType();

            var myObject = new Program();

            // ***** DELEGATES: *****
            // call the method directly, the classical approach
            myObject.MyActionMethod(1);

            // define a delegate to a specific method
            Action<int> myAction = myObject.MyActionMethod;

            // use the delegate myAction
            myAction(2);

            // use a delegate as parameter, for event-handling
            myObject.Calculation(3, myObject.MyActionMethod);

            // define the delegate with a lambda expression
            myObject.Calculation(4, (num) => { Console.WriteLine($"Lamda called {num}!"); }); 



            // ***** EVENT-HANDLING: *****
            // define an event
            myObject.MyEvent += myObject.MyEventHandler;
            myObject.MyEvent += (sender, e) => { Console.WriteLine($"MyLambdaEventhandler called"); };
            myObject.Calculation(5);
        }


        public void MyActionMethod(int i)
        {
            Console.WriteLine(i);
        }

        public void Calculation(int inputParam, Action<int> calledWhenFinished)
        {
            int result = inputParam * 2 / 2;
            // a very long lasting operation
            // usually put into a separate thread
            Thread.Sleep(3000);
            calledWhenFinished(result);
        }


        // ***** EVENT-HANDLING: *****
        public event EventHandler? MyEvent;

        public void MyEventHandler(object? sender, EventArgs e)
        {
            Console.WriteLine("MyEventHandler called!");
        }

        public void Calculation(int inputParam)
        {
            int result = inputParam * 2 / 2;
            // a very long lasting operation
            // usually put into a separate thread
            Thread.Sleep(3000);
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
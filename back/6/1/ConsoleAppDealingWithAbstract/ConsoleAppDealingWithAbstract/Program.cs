using System;

namespace ConsoleAppDealingWithAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _initShapesArray();
            _runAllDraw(_initShapesArray());
            _CalcAllAreas(_initShapesArray());
            Console.ReadKey();
        }

        private static Shape[] _initShapesArray()
        {
            Circle circle = new Circle(10, "red");
            Rectangle rectangle = new Rectangle("blue", 10, 10);
            Triangle triangle = new Triangle("yellow", 3, 4, 5);


            Shape[] shape = new Shape[] { circle, rectangle, triangle };

            return shape;
        }

        private static void _runAllDraw(Shape[] shape)
        {
            Console.WriteLine("\t*****Draw*****");
            for (int i = 0; i < shape.Length; i++)
            {
                Console.WriteLine($"{shape[i].Draw()}");
            }

        }

        private static void _CalcAllAreas(Shape[] shape)
        {
            Console.WriteLine("\t*****All Areas*****");
            float allAreas = 0;
            for (int i = 0; i < shape.Length; i++)
            {
                allAreas += shape[i].CalcArea();
            }
            Console.WriteLine($"All Areas = {allAreas}");
        }
    }
}

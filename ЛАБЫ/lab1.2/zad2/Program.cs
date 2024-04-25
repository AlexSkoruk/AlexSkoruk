using System;
using zad2.Figura;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraCollection shapesCollection = new FiguraCollection();

            Circle circle = new Circle { Radius = 5 };
            Rectangle    rectangle = new Rectangle  { Width = 4, Height = 6 };
            Triangle triangle = new Triangle { Base = 3, Height = 8 };

            shapesCollection.AddShape(circle);
            shapesCollection.AddShape(rectangle);
            shapesCollection.AddShape(triangle);

            double circleArea = circle.GetPloshad();
            double rectangleArea = rectangle.GetPloshad();
            double triangleArea = triangle.GetPloshad();

            Console.WriteLine("Площадь круга: " + circleArea);
            Console.WriteLine("Площадь прямоугольника: " + rectangleArea);
            Console.WriteLine("Площадь треугольника: " + triangleArea);

            double totalPloshad = shapesCollection.GetTotalArea();

            Console.WriteLine("Общая площадь всех фигур: " + totalPloshad);
        }
    }
}
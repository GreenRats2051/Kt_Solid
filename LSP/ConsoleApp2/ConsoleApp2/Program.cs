using ConsoleApp2;

IFigure rectangle = new Rectangle(5, 10);
Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");

IFigure triangle = new Triangle(5, 10);
Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}");
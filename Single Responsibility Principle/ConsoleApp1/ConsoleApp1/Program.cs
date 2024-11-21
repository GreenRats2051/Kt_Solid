using ConsoleApp1;

Circle circle = new Circle(5);
CircleCalculator calculator = new CircleCalculator();

double area = calculator.CalculateArea(circle);
double circumference = calculator.CalculateCircumference(circle);

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Circumference: {circumference}");
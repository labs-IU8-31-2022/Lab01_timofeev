Console.WriteLine("Введите две стороны прямоугольника через пробел");
var s1 = Convert.ToDouble(Console.ReadLine());
var s2 = Convert.ToDouble(Console.ReadLine());
Rectangle rec = new (s1, s2);
Console.WriteLine($"Периметр прямоугольника {rec.Perimeter}");
Console.WriteLine($"Площадь прямоугольника {rec.Area}");

public class Rectangle
{
    private double Side1;
    private double Side2;

    public Rectangle() : this(0,0) {}
    public Rectangle(double side1, double side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    private double AreaCalculator() => Side1 * Side2;
    private double PerimeterCalculator() => (Side1 + Side2) * 2;

    public double Area => AreaCalculator();
    public double Perimeter => PerimeterCalculator();

}
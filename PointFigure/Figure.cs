Point p1 = new(1, 3);
Point p2 = new(3, 5);
Point p3 = new(6, 1);
Point p4 = new(9, 1);
Point p5 = new(10, 4);
double res;
Figure f1 = new(p1, p2, p3);
f1.PerimeterCalculator(out res);
Console.WriteLine($"{f1.Name} периметр {res}");
Figure f2 = new(p1, p2, p3, p4);
f2.PerimeterCalculator(out res);
Console.WriteLine($"{f2.Name} периметр {res}");
Figure f3 = new(p1, p2, p3, p4, p5);
f3.PerimeterCalculator(out res);
Console.WriteLine($"{f3.Name} периметр {res}");


public class Point
{
    private int x;
    private int y;
    

    public int X => x;
    public int Y => y;
    
    
    public Point() : this(0, 0) {}

    public Point(int a1, int a2)
    {
        x = a1;
        y = a2;
    }
}

public class Figure
{
    private string name;
    private Point[] _points;
    
    public string Name => name;

    public Figure(params Point[] points)
    {
        switch (points.Length)
        {
            case 3:
                name = "Треугольник";
                break;
            case 4:
                name = "Прямоугольник";
                break;
            case 5:
                name = "Пятиугольник";
                break;
        }

        _points = points;
    }

    private double LengthSide(Point a, Point b) => Math.Pow(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2), 0.5);

    public void PerimeterCalculator(out double res)
    {
        res = 0;
        for (var i = 1; i < _points.Length; ++i)
        {
            res += LengthSide(_points[i - 1], _points[i]);
        }

        res += LengthSide(_points[^1], _points[0]);
    }
}
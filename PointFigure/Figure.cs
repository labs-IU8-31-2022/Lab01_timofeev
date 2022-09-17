


public class Point
{
    private int x;
    private int y;
    private string name;

    public int X => x;
    public int Y => y;
    public string Name => name;
    
    public Point() : this(0, 0, "") {}

    public Point(int a1, int a2, string n)
    {
        x = a1;
        y = a2;
        name = n;
    }
}

public class Figure
{
    private Point[] _points; 
    
    public Figure(params Point[] points)
    {
        
    }
}
using System.Drawing;

namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Rectangle()
    {
        Rectangle t1 = new (4, 3.4);
        Assert.AreEqual(14.8, t1.Perimeter);
        Assert.AreEqual(13.6, t1.Area);

        Rectangle t2 = new ();
        Assert.AreEqual(0, t2.Area);
        Assert.AreEqual(0, t2.Perimeter);
    }

    [TestMethod]
    public void Figure()
    {
        Point p1 = new(5, 6);
        Point p2 = new(8, 10);
        Point p3 = new(10, 12);

        Figure f = new(p1, p2, p3);
        double res = 0;
        f.PerimeterCalculator(out res);
        Assert.AreEqual(15, (int)res);
    }
}
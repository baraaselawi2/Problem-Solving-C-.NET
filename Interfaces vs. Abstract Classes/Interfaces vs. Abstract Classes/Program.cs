var shapes = new List<IShape>
{
    new Circule { radius = 5 },
    new Rectangle { width = 4, height = 6 }
};
foreach (var shape in shapes)
{
    if (shape is Circule circle)
    {
        Console.WriteLine($"Circle with radius {circle.radius}");
    }
    else if (shape is Rectangle rectangle)
    {
        Console.WriteLine($"Rectangle with width {rectangle.width} and height {rectangle.height}");
    }
    else
    {
        Console.WriteLine("Unknown shape");
    }
}
public abstract class Shape: IShape
{
    public abstract double Area();
}
interface IShape
{
    double Area();
}
public class Circule : IShape
{
    public double radius { get; set; }
    const double pi = 3.14;
    public double Area()
    {
        return pi * radius * radius;
    }
}
public class Rectangle : IShape
{
    public double width { get; set; }
    public double height { get; set; }
    public double Area()
    {
        return width * height;
    }
}
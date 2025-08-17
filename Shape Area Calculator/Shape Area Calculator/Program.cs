List<Shape> shapes = new List<Shape>();

shapes.Add(new Circle(5));
shapes.Add(new Circle(20));
shapes.Add(new Rectangle(4, 6));
shapes.Add(new Rectangle(9, 20));
shapes.Add(new Rectangle(40, 6));
foreach (var shape in shapes)
{
    if (shape is Circle circle)
    {
        Console.WriteLine($"Area Of Circule = {shape.GetArea()}");
    }
}
foreach (var shape in shapes)
{
    if (shape is Rectangle rectangle)
    {
        Console.WriteLine($"Area Of Rectangle = {shape.GetArea()}");
    }
}
public abstract class Shape
{
    public abstract double GetArea();
}
public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        double pi = 3.14;
        return pi * radius * radius;
    }
}
public class Rectangle : Shape
{
    private double height;
    private double width;
    public Rectangle(double width , double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double GetArea()
    {
        
        return width * height;
    }
}

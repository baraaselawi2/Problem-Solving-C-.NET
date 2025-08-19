List<Shape> shapes = new List<Shape>
{
    new Circle(),
    new Triangle(),
    new Square()
};
foreach (Shape shape in shapes)
{

    shape.Draw();
}

public class Shape {

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
public class Circle: Shape {
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
public class Triangle : Shape {
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
    }
}
public class Square : Shape {
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}



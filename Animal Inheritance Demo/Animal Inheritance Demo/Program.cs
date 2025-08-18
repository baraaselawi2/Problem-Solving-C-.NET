List<Animal> animalsound = new List<Animal>
{
    new Cat(),
    new Dog()
};
foreach (var item in animalsound)
{
    if (item is Cat cat)
        Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"This cat sound  {item.Speak()}");
}
foreach (var item in animalsound)
{
    if (item is Dog dog)
        Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"This Dog  sound  {item.Speak()}");
}

foreach (var item in animalsound)
{
    Console.WriteLine($"THis The Voice of dog and cat {item.Speak()}");
}

public class Animal
{
    public virtual string Speak()
    {
        return "hi";
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Cat voice mew";

    }
}
public class Dog : Animal
{
    public override string Speak()
    {
        return "Dog voice hwhwhwhw ";

    }
}
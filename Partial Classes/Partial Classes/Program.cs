var baraa = new Baraa
{
    Name = "Baraa",
    Age = 25,
    height = 170
};
Console.WriteLine(baraa.GetInfo());

partial class Baraa { 

public int Age { get; set; } 
    public int height { get; set; } 

    public int sum => Age + height;

}
partial class Baraa
{
    public string Name { get; set; }
    public string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}, Height: {height}, Sum: {sum}";
    }
}


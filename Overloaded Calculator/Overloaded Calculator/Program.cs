var add = new Calculator();
add.Add(1, 1);
add.Add(2.2, 9.3);
add.Add(1, 2, 3, 4);
public class Calculator
{
    public void Add(int x , int y)
    {
        Console.WriteLine(x + y);
    }
    public void Add(double x , double y)
    {
        Console.WriteLine(x + y);
    }
    public void Add(params int[] x)
    {
        int sum = x.Sum();
        Console.WriteLine(sum);
    }

}
var Calculator = new calculator();

Console.WriteLine(Calculator.Compute(4, 3, (x, y) => x + y)); 
Console.WriteLine(Calculator.Compute(5, 3, (x, y) => x - y));
Console.WriteLine(Calculator.Compute(5, 3, (x, y) => x * y)); 
Console.WriteLine(Calculator.Compute(5, 3, (x, y) => x / y)); 


public class calculator
{
    public int Compute(int x, int y, Func<int, int, int> operation)
    {
                return operation(x, y);
    }
}
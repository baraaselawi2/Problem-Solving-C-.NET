List<Func<int, int, int>> operations = new List<Func<int, int, int>>
{
    (x, y) => x + y,
    (x, y) => x - y,
    (x, y) => x * y,
    (x, y) => x / y
};
foreach (var op in operations)
{
    Console.WriteLine(op(5, 10));
}

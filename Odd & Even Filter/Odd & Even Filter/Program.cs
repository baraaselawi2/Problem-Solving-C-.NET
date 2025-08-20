List<int> numbers = new List<int> { 1,10,30, 2, 3, 4, 5, 6, 7, 8 };

Func<int, bool> func = x => x % 2 == 0;
var evens = numbers.Where(func);

foreach (var number in evens)
{
    Console.WriteLine(number);
}

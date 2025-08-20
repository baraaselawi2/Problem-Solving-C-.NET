List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Func<int, int> transform = x => x * x;
Action<int> logger = x => Console.WriteLine($"Result = {x}");
ints.Select(transform).ToList().ForEach(logger);

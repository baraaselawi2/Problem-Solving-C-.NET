List<string> strings = new List<string>
{
    "Baraa",
    "Selawi",
    "test"
};
Func<string, string> transformer = name => name.ToLower();
Action<string> Print = name => Console.WriteLine(name);

strings.Select(transformer).ToList().ForEach(Print);


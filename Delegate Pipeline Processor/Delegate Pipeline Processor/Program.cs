Func<string, string> upperCase = s => s.ToUpperInvariant();
Func<string, string> Tirm = s => s.Trim();
Func<string, string> Timestamp = s => $"{s} - {DateTime.Now:O}";
var pipeline = new Func<string, string>[] { upperCase, Tirm, Timestamp };
foreach (var item in pipeline)
{
    Console.WriteLine(item("  Hello World  "));
}




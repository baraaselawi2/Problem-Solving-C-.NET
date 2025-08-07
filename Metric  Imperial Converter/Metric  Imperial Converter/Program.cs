Dictionary<string, double> MetersCalculator = new Dictionary<string, double>() {
    { "m", 1.09361},
    { "Km", 0.621371},
    { "yd", 0.9144 },
    { "mi", 1.60934}
};

while (true)
{
    Console.WriteLine("Enter the number ");
    string metertinput = Console.ReadLine();
    double vlaue = double.Parse(metertinput);

    Console.WriteLine("Enter the unit name ");
    string unit = Console.ReadLine();

    switch (unit)
    {
        case "m":
            double metertoyard = vlaue * MetersCalculator["m"];
            double yardtometer = metertoyard / MetersCalculator["m"];
            Console.WriteLine($"{vlaue} m = {metertoyard:F3} yd");
            Console.WriteLine($"{metertoyard:F3} yd = {yardtometer:F3} m");
            break;

        case "Km":
            double kilotomils = vlaue * MetersCalculator["Km"];
            double milestokilo = kilotomils / MetersCalculator["Km"];
            Console.WriteLine($"{vlaue} Km = {kilotomils:F3} mi");
            Console.WriteLine($"{kilotomils:F3} mi = {milestokilo:F3} Km");
            break;

        case "yd":
            double yardtometers = vlaue * MetersCalculator["yd"];
            double metertoyards = yardtometers / MetersCalculator["yd"];
            Console.WriteLine($"{vlaue} yd = {yardtometers:F3} m");
            Console.WriteLine($"{yardtometers:F3} m = {metertoyards:F3} yd");
            break;

        case "mi":
            double milestokm = vlaue * MetersCalculator["mi"];
            double kmtomiles = milestokm / MetersCalculator["mi"];
            Console.WriteLine($"{vlaue} mi = {milestokm:F3} Km");
            Console.WriteLine($"{milestokm:F3} Km = {kmtomiles:F3} mi");
            break;

        default:
            Console.WriteLine("anonymos op");
            continue;
    }
}

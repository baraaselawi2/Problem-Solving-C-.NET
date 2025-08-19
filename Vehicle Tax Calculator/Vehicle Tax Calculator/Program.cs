List<Vehicle> vehicles = new List<Vehicle>
{
    new Car { WeightKg = 1500, EngineSizeCc = 2000 },
    new Truck { WeightKg = 8000, EngineSizeCc = 5000 },
    new Motorcycle { WeightKg = 200, EngineSizeCc = 600 }
};
foreach (var vehicle in vehicles)
{
    if (vehicle is Car car)
    {
        Console.WriteLine($"Car Tax : {car.CalculateTax()}");
    }
    else if (vehicle is Truck truck)
    {
        Console.WriteLine($"Truck Tax : {truck.CalculateTax()}");
    }
    else if (vehicle is Motorcycle motorcycle)
    {
        Console.WriteLine($"Motorcycle Tax : {motorcycle.CalculateTax()}");
    }
    else {        
        Console.WriteLine("Unknown vehicle type."); 
    }
}

public interface ITaxable
{
    decimal CalculateTax();
}
public abstract class Vehicle
{
    public decimal WeightKg { get; set; }
    public decimal EngineSizeCc { get; set; }
}
public class Car : Vehicle, ITaxable
{
    public decimal CalculateTax()
    {
        
        return (WeightKg * 0.01m) + (EngineSizeCc * 0.001m);
    }
}
public class Truck : Vehicle, ITaxable
{
    public decimal CalculateTax()
    {
        
        return (WeightKg * 0.30m) + (EngineSizeCc * 0.011m);
    }
}
public class Motorcycle : Vehicle, ITaxable
{
    public decimal CalculateTax()
    {
        
        return (WeightKg * 0.21m) + (EngineSizeCc * 0.91m);
    }
}
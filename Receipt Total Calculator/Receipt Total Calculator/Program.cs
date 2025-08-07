using System.Numerics;

decimal Price = 0;
decimal quantity = 0;
bool IsVaild = false;

while (!IsVaild)
{
    Console.WriteLine("Enter The Price Of The Product:\n");
    string PriceEnter = Console.ReadLine();
    if (decimal.TryParse(PriceEnter, out Price))
    {
        IsVaild = true;
    }
    else
    {
        Console.WriteLine("Invalid Numbers Retry Again\n");
    }

    IsVaild = false;

    while (!IsVaild)
    {
        Console.WriteLine("Enter The Price Of The Product:\n");
        string quantityEnter = Console.ReadLine();
        if (decimal.TryParse(quantityEnter, out quantity))
        {
            IsVaild = true;
        }
        else
        {
            Console.WriteLine("Invalid Numbers Retry Again\n");
        }
    }
}

decimal Total = quantity * Price;

Console.WriteLine("///////////////////The Receipt////////////////////\n");
Console.WriteLine($"The Price ${Price}\n");
Console.WriteLine($"The Quantity {quantity}\n");
Console.WriteLine($"The Total Price\n${Total.ToString("f2")}\n");






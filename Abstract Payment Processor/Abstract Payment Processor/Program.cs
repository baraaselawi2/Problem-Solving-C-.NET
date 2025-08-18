List<PaymentProcessor> processors = new List<PaymentProcessor>
{
    new CardProcessor(),
    new CashProcessor()
};
foreach (var processor in processors)
{
    processor.Process(100);
}

public abstract class PaymentProcessor {

    public abstract void Process(decimal amount);
 
}

public class CardProcessor : PaymentProcessor
{
    public override void Process(decimal amount)
    {
        amount = amount * 0.98m;
        Console.WriteLine($"this with card {amount}");
    }
}



public class CashProcessor : PaymentProcessor
{
    public override void Process(decimal amount)
    {
     amount = amount * 0.95m;
        Console.WriteLine($"this with cash {amount}");
    }
}
using System.Security.Cryptography.X509Certificates;
var account = new Account
{
    Balance = 1000,
    AccountNumber = 123456
};
Console.WriteLine($"Initial Balance = {account.Balance}");
account.ProcessTransaction(500, amount => account.Deposit(amount));
Console.WriteLine($"After Deposit: {account.Balance}");
account.ProcessTransaction(300, amount => account.Withdraw(amount));
Console.WriteLine($"After Withdraw: {account.Balance}");
public class Account
{
    public decimal Balance { get; set; }
    public int AccountNumber { get; set; }
    public decimal Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        Balance += amount;
        return Balance;
    }
    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }
        Balance -= amount;
        return Balance;
    }
    public decimal ProcessTransaction(decimal amount, Func<decimal, decimal> operation)
    {
        return amount;

    }
}

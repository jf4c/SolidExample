namespace Solid._03_LSP.Bad;

public class BankAccount
{
    public virtual void withdraw(decimal amount)
    {
        Console.WriteLine($"Withdraw: {amount}");
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }
    
    public override void withdraw(decimal amount)
    {
        if (Balance < amount)
            throw new Exception("Insufficient funds");
        
        Balance -= amount;
        Console.WriteLine($"Withdraw: {amount}");
    }
}
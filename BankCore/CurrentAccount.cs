using System.IO.Pipes;
using System.Runtime;

public class CurrentAccount : Account
{

    public decimal OverdraftLimit { get; }
    public CurrentAccount(
        string accountNumber,
        string ownerName,
        decimal overdraftLimit
    ) : base(accountNumber, ownerName)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        if (amount > Balance + OverdraftLimit)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }





}
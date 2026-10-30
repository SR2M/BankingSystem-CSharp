public abstract class Account
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public decimal Balance { get; protected set;}

    public Account(
        string accontNumber, 
        string ownerName
    )
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }


    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }
        Balance += amount;
    }

    public abstract bool Withdraw(decimal amount);

















}
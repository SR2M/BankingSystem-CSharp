public class TransactionService : ITransactionService
{
    public bool Transfer(
        Account source,
        Account destination,
        decimal amount
    )
    {
        if (amount <= 0)
        {
            return false;
        }
        
        bool success = source.Withdraw(amount);

        if (!success)
        {
            return false;
        }

        destination.Deposit(amount);
        return true;
    } 
}
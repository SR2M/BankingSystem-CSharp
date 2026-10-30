public class SavingAccont : Account
{
    public SavingAccont(
        string accountNumber,
        string ownerName
    ) : base(accountNumber, ownerName)
    {
        
    }

     public override bool Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            return false;
        }

        if(amount > Balance)
        {
            return false;
        }
        Balance -= amount;

        return true;
    }











}
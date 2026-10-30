public interface ITransactionService
{
    bool Transfer(
        Account source,
        Account destination,
        decimal amount
    );
}
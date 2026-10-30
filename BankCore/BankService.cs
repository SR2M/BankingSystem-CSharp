public class BankService
{
    private readonly INotificationService _notoficationService;

    public BankService(
        INotificationService notificationService
    )
    {
        _notoficationService = notificationService;
    }

    public void NotifyTransfer()
    {
        _notoficationService.send("Transfer completed successfully.");
    }
}
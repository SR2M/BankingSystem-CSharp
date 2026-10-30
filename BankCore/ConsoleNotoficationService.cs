public class ConsoleNotificationService : INotificationService
{
    public void send(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}
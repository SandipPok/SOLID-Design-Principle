namespace Open_Close_Principle.Methods.Notification_System
{
    public interface INotification
    {
        void Send(string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
    public class NotificationSender
    {
        private readonly INotification _channel;
        public NotificationSender(INotification channel)
        {
            _channel = channel;
        }
        public void SendNotification(string message)
        {
            _channel.Send(message);
        }
    }
}

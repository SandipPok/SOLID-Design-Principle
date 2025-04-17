namespace DemoLibrary.Interface
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}
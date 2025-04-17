using DemoLibrary.Interface;

namespace DemoLibrary.Methods
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email on {person.EmailAddress}");
        }
    }
}

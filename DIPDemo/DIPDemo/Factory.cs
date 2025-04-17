using DemoLibrary.Interface;
using DemoLibrary.Methods;

namespace DIPDemo
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore() => new Chore(CreateLogger(), CreateMessageSender());
        public static ILogger CreateLogger() => new Logger();
        public static IMessageSender CreateMessageSender() => new Texter();
    }
}

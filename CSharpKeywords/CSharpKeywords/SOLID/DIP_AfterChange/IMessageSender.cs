namespace CSharpRef.SOLID.DIP_AfterChange
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}
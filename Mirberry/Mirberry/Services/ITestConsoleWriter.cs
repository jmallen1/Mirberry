namespace Mirberry.Services
{
    public interface ITestConsoleWriter
    {
        void SendMessage(string to, string subject, string body);
    }
}
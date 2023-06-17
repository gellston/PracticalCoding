using PrismFullAppExample.Services.Interfaces;

namespace PrismFullAppExample.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

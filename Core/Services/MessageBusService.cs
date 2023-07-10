using Core.Services.Interfaces;
using Models;

namespace Core.Services;

public class MessageBusService: IMessageBusService
{

    public MessageBusService()
    {
        
    }
    
    public void Publish<T>(PayRun payRun) where T : class
    {
        
    }
}
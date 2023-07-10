using Models;

namespace Core.Services.Interfaces;

public interface IMessageBusService
{
    void Publish<T>(PayRun payRun) where T : class;
}
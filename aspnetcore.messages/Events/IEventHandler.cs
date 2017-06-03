using System.Threading.Tasks;

namespace aspnetcore.messages.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
        
    }
}

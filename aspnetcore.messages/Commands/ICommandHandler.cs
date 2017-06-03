using System;
using System.Threading.Tasks;

namespace aspnetcore.messages.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
        
    }
}

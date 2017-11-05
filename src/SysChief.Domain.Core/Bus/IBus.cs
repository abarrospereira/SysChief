using System.Threading.Tasks;
using SysChief.Domain.Core.Commands;
using SysChief.Domain.Core.Events;

namespace SysChief.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
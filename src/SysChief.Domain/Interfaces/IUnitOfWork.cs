using System;
using SysChief.Domain.Core.Commands;

namespace SysChief.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}

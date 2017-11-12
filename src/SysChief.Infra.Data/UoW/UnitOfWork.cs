using SysChief.Domain.Core.Commands;
using SysChief.Domain.Interfaces;
using SysChief.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysChief.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SysChiefContext _context;

        public UnitOfWork(SysChiefContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

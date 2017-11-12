using System;
using System.Collections.Generic;
using SysChief.Application.EventSourcedNormalizers;
using SysChief.Application.ViewModels;

namespace SysChief.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(long id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(long id);
     //   IList<CustomerHistoryData> GetAllHistory(long id);
    }
}

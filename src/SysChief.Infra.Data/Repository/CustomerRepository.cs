using System.Linq;
using SysChief.Domain.Interfaces;
using SysChief.Domain.Models;
using SysChief.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace SysChief.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SysChiefContext context)
            : base(context)
        {

        }

        public Customer GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}

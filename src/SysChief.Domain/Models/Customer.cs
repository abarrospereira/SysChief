using System;
using SysChief.Domain.Core.Models;

namespace SysChief.Domain.Models
{
    public class Customer : Entity
    {
        public Customer(Guid id, string name, string email, DateTime birthDate)
        {
           id = new Guid();
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        // Empty constructor for EF
        protected Customer() { }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}
using System;
using SysChief.Domain.Core.Events;

namespace SysChief.Domain.Events
{
    public class CustomerRegisteredEvent : Event
    {
        public CustomerRegisteredEvent(string name, string email, DateTime birthDate)
        {
         
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public long Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}
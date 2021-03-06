﻿using System;
using SysChief.Domain.Core.Commands;

namespace SysChief.Domain.Commands
{
    public abstract class CustomerCommand : Command
    {
        public long Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }
    }
}
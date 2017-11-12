﻿using SysChief.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysChief.Infra.Data.Repository.EventSourcing
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        //IList<StoredEvent> All(Guid aggregateId);
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShoppingCartConceptDDD.DomainEvent
{
    public interface IEventHandler<T> where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }
}

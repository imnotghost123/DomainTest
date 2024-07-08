using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class AggregateRoot<TId> :Entity<TId> where TId : class
    {
        protected AggregateRoot(TId id) : base(id) { }
    }
}

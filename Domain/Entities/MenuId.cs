using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MenuId : ValueObject
    {
        public Guid Value { get; set; }

        public MenuId(Guid value)
        {
            Value = value;
        }
    }
}

using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Menu : AggregateRoot<MenuId>
    {

        public string Name { get; }

        public string Description { get; }

        public float AverageRating { get; set; }
    }
}

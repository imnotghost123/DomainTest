using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomainSingle.V3
{

    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public Task<List<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

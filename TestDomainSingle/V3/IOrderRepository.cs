using System.Collections.Generic;

namespace TestDomainSingle.V3
{
    public interface IOrderRepository
    {
        Task <List<Order>> GetAllAsync();
    }
}
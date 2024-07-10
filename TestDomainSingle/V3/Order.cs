using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomainSingle.V3
{
    public class Order
    {
        public long OrderId { get; }
        public string CustomerName { get; }
        public DateTime OrderDate { get; set; }
        public List<string> Products { get; }

        public Order(long orderId, string customerName, DateTime orderDate, List<string> products)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderDate = orderDate;
            Products = products;
        }
    }
}

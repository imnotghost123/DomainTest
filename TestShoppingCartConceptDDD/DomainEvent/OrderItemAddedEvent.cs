using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShoppingCartConceptDDD.ValueObjects;

namespace TestShoppingCartConceptDDD.DomainEvent
{
    public class OrderItemAddedEvent : IDomainEvent
    {
        public Guid OrderId { get; }
        public Guid ProductId { get; }
        public int Quantity { get; }
        public Money UnitPrice { get; }
        public DateTime OccurredOn { get; }

        public OrderItemAddedEvent(Guid orderId, Guid productId, int quantity, Money unitPrice)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            OccurredOn = DateTime.UtcNow;
        }
    }

}

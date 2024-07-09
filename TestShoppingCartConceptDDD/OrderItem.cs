using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShoppingCartConceptDDD.ValueObjects;

namespace TestShoppingCartConceptDDD
{
    public class OrderItem
    {
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public Money UnitPrice { get; private set; }

        public OrderItem(Guid productId, int quantity, Money unitPrice)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");

            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        }

        public void UpdateQuantity(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
            Quantity = quantity;
        }

        public Money GetTotal()
        {
            return new Money(Quantity * UnitPrice.Amount, UnitPrice.Currency);
        }
    }
}

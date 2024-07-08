using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShoppingCartConceptDDD
{
    public class OrderItem
    {
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public OrderItem(Guid productId, int quantity, decimal unitPrice)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
            if (unitPrice <= 0) throw new ArgumentException("Unit price must be greater than zero.");

            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public void UpdateQuantity(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
            Quantity = quantity;
        }

        public decimal GetTotal()
        {
            return Quantity * UnitPrice;
        }
    }
}

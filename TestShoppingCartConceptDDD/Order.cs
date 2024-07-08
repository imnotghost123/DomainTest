
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//public class ShoppingCart
//{

//    public ShoppingCart(Guid sid, Guid csid)
//    {
//        ShoppingCartId = sid;
//        CustomerID = csid;
//    }

//    public Guid ShoppingCartId { get; private set; }

//     public Guid CustomerID { get; private set; }

//     public List<ShoppingCartItems>  Items { get;  set; }    = new List<ShoppingCartItems>();

//    public void AddItems(Guid productId, int quantity, decimal price)
//    {
//        var existItem =Items.SingleOrDefault(x.ShoppingCartItem=> x.ProductId  == productId);

//        if (existItem != null)
//        {
//            existItem.IncrementQuantity(quantity);
//        }
//        else
//        {
//            Items.Add(new ShoppingCartItems(ShoppingCartId, productId, quantity, price));
//        }
//    }
//}

//public class ShoppingCartItems
//{ 
//    private readonly 
//}


// 聚合根：Order
namespace TestShoppingCartConceptDDD
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public string Customer { get; private set; }

        public Order(Guid orderId, string customer)
        {
            OrderId = orderId;
            OrderDate = DateTime.UtcNow;
            Customer = customer;
            Items = new List<OrderItem>();
        }

        public void AddItem(Guid productId, int quantity, decimal unitPrice)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.UpdateQuantity(existingItem.Quantity + quantity);
            }
            else
            {
                var orderItem = new OrderItem(productId, quantity, unitPrice);
                Items.Add(orderItem);
            }
        }
        //loosyly couple
        public void RemoveItem(Guid productId)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.GetTotal());
        }

        // 其他业务逻辑方法
    }
}


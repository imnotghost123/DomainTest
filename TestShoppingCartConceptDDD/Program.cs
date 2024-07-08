using System;
using TestShoppingCartConceptDDD;

namespace Application
{
    class Program
    {
        static void Main()
        {
            var orderId = Guid.NewGuid();
            var order = new Order(orderId, "Customer1");

            var productId1 = Guid.NewGuid();
            var productId2 = Guid.NewGuid();

            order.AddItem(productId1, 2, 100m);
            order.AddItem(productId2, 1, 200m);

            Console.WriteLine($"Order Total: {order.GetTotal()}");

            order.AddItem(productId1, 3, 100m);
            Console.WriteLine($"Order Total after adding more of product 1: {order.GetTotal()}");

            order.RemoveItem(productId2);
            Console.WriteLine($"Order Total after removing product 2: {order.GetTotal()}");
        }
    }
}

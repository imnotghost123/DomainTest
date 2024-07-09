using System;
using TestShoppingCartConceptDDD;
using TestShoppingCartConceptDDD.DomainEvent;
using TestShoppingCartConceptDDD.ValueObjects;

namespace Application
{
    class Program
    {
        static void Main()
        {
            //var eventBus = new EventBus();
            //var orderItemAddedHandler = new OrderItemAddedEventHandler();
            //eventBus.Register(orderItemAddedHandler);

            //var orderId = Guid.NewGuid();
            //var order = new Order(orderId, "Customer1");

            //var productId1 = Guid.NewGuid();
            //var productId2 = Guid.NewGuid();

            //var price1 = new Money(100m, "USD");
            //var price2 = new Money(200m, "USD");

            //order.AddItem(productId1, 2, price1);
            //order.AddItem(productId2, 1, price2);

            //foreach (var domainEvent in order.DomainEvents)
            //{
            //    eventBus.Publish(domainEvent);
            //}

            //order.ClearDomainEvents();

            //Console.WriteLine($"Order Total: {order.GetTotal().Amount} {order.GetTotal().Currency}");

            //order.AddItem(productId1, 3, price1);
            //foreach (var domainEvent in order.DomainEvents)
            //{
            //    eventBus.Publish(domainEvent);
            //}

            //order.ClearDomainEvents();

            //Console.WriteLine($"Order Total after adding more of product 1: {order.GetTotal().Amount} {order.GetTotal().Currency}");

            //order.RemoveItem(productId2);
            //foreach (var domainEvent in order.DomainEvents)
            //{
            //    eventBus.Publish(domainEvent);
            //}

            //order.ClearDomainEvents();

            //Console.WriteLine($"Order Total after removing product 2: {order.GetTotal().Amount} {order.GetTotal().Currency}");

            var eventBus = new EventBus();
            var orderItemAddedHandler = new OrderItemAddedEventHandler();
            eventBus.Register(orderItemAddedHandler);

            var orderId = Guid.NewGuid();
            var order = new Order(orderId, "Customer1");

            var productId1 = Guid.NewGuid();
            var productId2 = Guid.NewGuid();

            var price1 = new Money(100m, "USD");
            var price2 = new Money(200m, "USD");

            order.AddItem(productId1, 2, price1);
            order.AddItem(productId2, 1, price2);

            foreach (var domainEvent in order.DomainEvents)
            {
                eventBus.Publish(domainEvent);
            }

            order.ClearDomainEvents();

            Console.WriteLine($"Order Total: {order.GetTotal().Amount} {order.GetTotal().Currency}");

            order.AddItem(productId1, 3, price1);
            foreach (var domainEvent in order.DomainEvents)
            {
                eventBus.Publish(domainEvent);
            }

            order.ClearDomainEvents();

            Console.WriteLine($"Order Total after adding more of product 1: {order.GetTotal().Amount} {order.GetTotal().Currency}");

            order.RemoveItem(productId2);
            foreach (var domainEvent in order.DomainEvents)
            {
                eventBus.Publish(domainEvent);
            }

            order.ClearDomainEvents();

            Console.WriteLine($"Order Total after removing product 2: {order.GetTotal().Amount} {order.GetTotal().Currency}");
        }
    }
}

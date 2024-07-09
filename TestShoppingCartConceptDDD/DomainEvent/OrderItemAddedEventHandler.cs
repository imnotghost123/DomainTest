namespace TestShoppingCartConceptDDD.DomainEvent
{
    public class OrderItemAddedEventHandler : IEventHandler<OrderItemAddedEvent>
    {
        public void Handle(OrderItemAddedEvent domainEvent)
        {
            Console.WriteLine($"Order item added: OrderId={domainEvent.OrderId}, ProductId={domainEvent.ProductId}, Quantity={domainEvent.Quantity}, UnitPrice={domainEvent.UnitPrice.Amount}");
        }
    }
}

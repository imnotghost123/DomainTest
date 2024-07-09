namespace TestShoppingCartConceptDDD.DomainEvent
{
    public class EventBus
    {
        private readonly Dictionary<Type, List<object>> _handlers = new Dictionary<Type, List<object>>();

        public void Register<T>(IEventHandler<T> handler) where T : IDomainEvent
        {
            if (!_handlers.ContainsKey(typeof(T)))
            {
                _handlers[typeof(T)] = new List<object>();
            }

            _handlers[typeof(T)].Add(handler);
        }

        public void Publish(IDomainEvent domainEvent)
        {
            var eventType = domainEvent.GetType();
            if (_handlers.ContainsKey(eventType))
            {
                foreach (var handler in _handlers[eventType])
                {
                    ((IEventHandler<IDomainEvent>)handler).Handle(domainEvent);
                }
            }
        }
    }
}

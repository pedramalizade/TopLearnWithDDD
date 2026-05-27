namespace TopLearnWithDDD.Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }

        public int Version { get; protected set; }

        private bool _IsIncremented;
        protected void IncrementVersion()
        {
            if (_IsIncremented)
            {
                return;
            }

            Version++;
            _IsIncremented = true;
        }

        private List<IDomainEvent> _events = new();
        public IEnumerable<IDomainEvent> Events => _events;

        protected void RaiseDomainEvent(IDomainEvent @event)
        {
            if(!_events.Any() && !_IsIncremented)
            {
                Version++;
                _IsIncremented = true;
            }
            _events.Add(@event);
        }
    }
}

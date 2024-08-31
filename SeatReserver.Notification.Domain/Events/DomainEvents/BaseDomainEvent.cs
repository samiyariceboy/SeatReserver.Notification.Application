using MediatR;

namespace SeatReserver.Notification.Domain.Events.DomainEvents
{
    public interface IDomainEvent : INotification
    {
        public EventLocation EventLocation { get; }
    }

    public enum EventLocation
    {
        Internal,
        External
    }
}

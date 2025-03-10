namespace TalentHub.HandshakeService.Infrastructure.Abstractions.DomainEvents;

public interface IEventHandler<in TEvent> where TEvent : IDomainEvent
{
    Task HandleAsync(TEvent @event);
}
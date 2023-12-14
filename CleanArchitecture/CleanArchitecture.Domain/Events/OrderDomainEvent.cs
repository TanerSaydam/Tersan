using MediatR;

namespace CleanArchitecture.Domain.Events;
public class OrderDomainEvent: INotification
{
    public Guid Id { get; set; }
    public OrderDomainEvent(Guid id)
    {
        Id = id;
    }
}

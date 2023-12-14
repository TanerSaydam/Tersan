using MediatR;

namespace CleanArchitecture.Domain.Events;

public class SendEmailOrderEvent : INotificationHandler<OrderDomainEvent>
{
    public async Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {        
        //Mail gönderme işlemi
        await Task.CompletedTask;
    }
}

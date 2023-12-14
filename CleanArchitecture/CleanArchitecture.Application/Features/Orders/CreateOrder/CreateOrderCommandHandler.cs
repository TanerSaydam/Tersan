using AutoMapper;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Events;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Orders.CreateOrder;

public sealed class CreateOrderCommandHandler(
    IOrderRepository orderRepository, 
    IUnitOfWork unitOfWork,
    IMapper mapper,
    IMediator mediator) : IRequestHandler<CreateOrderCommand>
{
    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Order order = mapper.Map<Order>(request);

        await orderRepository.CreateAsync(order, cancellationToken).ConfigureAwait(false);
        await unitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        await mediator.Publish(new OrderDomainEvent(order.Id));
        
    }
}

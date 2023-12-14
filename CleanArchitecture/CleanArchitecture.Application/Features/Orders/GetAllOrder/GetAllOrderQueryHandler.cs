using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Orders.GetAllOrder;

public sealed class GetAllOrderQueryHandler(IOrderRepository orderRepository) : IRequestHandler<GetAllOrderQuery, IQueryable<Order>>
{
    public async Task<IQueryable<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var response = orderRepository.GetAll();

        return response;
    }
}

using MediatR;

namespace CleanArchitecture.Application.Features.Orders.CreateOrder;
public sealed record CreateOrderCommand(
    Guid ProductId,
    decimal Price,
    string CustomerName): IRequest;

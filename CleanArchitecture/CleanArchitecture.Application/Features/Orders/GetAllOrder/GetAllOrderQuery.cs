using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.Orders.GetAllOrder;
public sealed record GetAllOrderQuery() : IRequest<IQueryable<Order>>;

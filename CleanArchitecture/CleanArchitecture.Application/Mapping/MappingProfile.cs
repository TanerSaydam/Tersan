using AutoMapper;
using CleanArchitecture.Application.Features.Orders.CreateOrder;
using CleanArchitecture.Application.Features.Products.CreateProduct;
using CleanArchitecture.Application.Features.Products.UpdateProduct;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateProductCommand, Product>();
        CreateMap<UpdateProductCommand, Product>();
        CreateMap<CreateOrderCommand, Order>();
    }
}

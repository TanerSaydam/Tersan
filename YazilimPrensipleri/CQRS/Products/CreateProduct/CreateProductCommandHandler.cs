using MediatR;

namespace CQRS.Products.CreateProduct;

public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, List<CreateProductCommandResponse>>
{
    public async Task<List<CreateProductCommandResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //Kayıt işlemi

        await Task.CompletedTask;
        return new();
    }
}

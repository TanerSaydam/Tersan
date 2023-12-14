using FluentValidation;

namespace CleanArchitecture.Application.Features.Products.CreateProduct;
public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MinimumLength(3);
        RuleFor(p => p.Price).GreaterThan(10);
        
    }
}

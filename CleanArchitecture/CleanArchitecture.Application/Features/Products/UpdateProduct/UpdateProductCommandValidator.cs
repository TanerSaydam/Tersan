using FluentValidation;

namespace CleanArchitecture.Application.Features.Products.UpdateProduct;
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MinimumLength(3);
        RuleFor(p => p.Price).GreaterThan(10);
    }
}

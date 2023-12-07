using FluentValidation;

namespace CleanArchitecture.Application.Features.Products.AddProduct;
public sealed class AddProductCommandValidator : AbstractValidator<AddProductCommand>
{
    public AddProductCommandValidator()
    {
        RuleFor(p=> p.Name).NotEmpty().WithMessage("Ürün adı boş olamaz");
        RuleFor(p=> p.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalı");
        RuleFor(p=> p.Price).GreaterThan(0).WithMessage("Ürün fiyatı 0 dan büyük olmalıdır");
    }
}

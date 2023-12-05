using FluentValidation;
using NTierArchitecture.Entities.Dtos;

namespace NTierArchitecture.Business.Validators;
public sealed class ProductValidator : AbstractValidator<ProductAddDto>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün adı boş olamaz");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır");
        RuleFor(p => p.Price).NotEmpty().WithMessage("Ürün fiyatı boş olamaz");
        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı 0 dan büyük olmalıdır");
    }
}

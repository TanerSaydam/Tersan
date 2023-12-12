using FluentValidation;
using TemizKodunOnemi.AdvancedOrnek.WebApi.DTOs;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Validators;

public sealed class CreateItemDtoValidator : AbstractValidator<CreateItemDto>
{
    public CreateItemDtoValidator()
    {
        RuleFor(p=> p.Name).NotEmpty().WithMessage("Item name cannot be empty or null");
    }
}

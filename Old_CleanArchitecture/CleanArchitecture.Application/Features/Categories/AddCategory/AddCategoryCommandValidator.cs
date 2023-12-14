using FluentValidation;

namespace CleanArchitecture.Application.Features.Categories.AddCategory;
public class AddCategoryCommandValidator : AbstractValidator<AddCategoryCommand>
{
    public AddCategoryCommandValidator()
    {
        RuleFor(p=> p.Name).NotEmpty().WithMessage("Kategori adı boş olamaz");
    }
}

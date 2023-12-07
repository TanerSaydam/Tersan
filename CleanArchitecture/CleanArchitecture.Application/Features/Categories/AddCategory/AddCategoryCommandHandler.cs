using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Features.Categories.AddCategory;

public sealed class AddCategoryCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<AddCategoryCommand, ErrorOr<string>>
{
    public async Task<ErrorOr<string>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
    {
        bool isNameExists = await categoryRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
        if (isNameExists)
        {
            return Error.Conflict(code: "CategoryNameExists", description: "Bu kategori adı daha önce kullanılmış");
        }

        Category category = new()
        {
            Id = Guid.NewGuid(),
            Name = request.Name
        };

        await categoryRepository.AddSaveAsync(category, cancellationToken);

        return "Kayıt işlemi başarıyla tamamlandı";
    }
}

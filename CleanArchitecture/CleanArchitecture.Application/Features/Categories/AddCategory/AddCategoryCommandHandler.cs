using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Categories.AddCategory;

public sealed class AddCategoryCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<AddCategoryCommand>
{
    public async Task Handle(AddCategoryCommand request, CancellationToken cancellationToken)
    {
        bool isNameExists = await categoryRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
        if (isNameExists)
        {
            throw new ArgumentException("Bu kategori adı daha önce kullanılmış");
        }

        Category category = new()
        {
            Id = Guid.NewGuid(),
            Name = request.Name
        };

        await categoryRepository.AddSaveAsync(category, cancellationToken);
    }
}

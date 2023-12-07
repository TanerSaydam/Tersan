namespace CleanArchitecture.Application.Features.Categories.AddCategory;

public sealed class CategoryNameExistsException : Exception
{
    public CategoryNameExistsException() : base("Bu kategori adı daha önce kullanılmış")
    {
        
    }
}

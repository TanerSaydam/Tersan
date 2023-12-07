using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Features.Categories.AddCategory;
public sealed record AddCategoryCommand(
    string Name): IRequest<ErrorOr<string>>;

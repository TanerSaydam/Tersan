using FluentValidation;
using UnderstandingDependecies.WebApi.DTOs;

namespace UnderstandingDependecies.WebApi.Validators;

public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(p => p.FullName).NotEmpty();
    }
}

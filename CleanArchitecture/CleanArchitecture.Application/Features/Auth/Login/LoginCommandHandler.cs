using CleanArchitecture.Application.Abstractions;
using MediatR;

namespace CleanArchitecture.Application.Features.Auth.Login;
public sealed class LoginCommandHandler(IJwtService jwtService) : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return jwtService.CreateToken(request.UserName);
    }
}

using MediatR;

namespace CleanArchitecture.Application.Features.Auth.Login;
public sealed record LoginCommand(string UserName): IRequest<string>;
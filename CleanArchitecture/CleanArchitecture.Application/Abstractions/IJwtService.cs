namespace CleanArchitecture.Application.Abstractions;
public interface IJwtService
{
    string CreateToken(string userName);
}

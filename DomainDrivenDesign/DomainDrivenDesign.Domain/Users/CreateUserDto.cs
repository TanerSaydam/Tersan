namespace DomainDrivenDesign.Domain.Users;

public sealed record CreateUserDto(
    string Name, 
    string Email, 
    string Country, 
    string City, 
    string Street, 
    string FullAddress, 
    decimal Amount, 
    string Currency);

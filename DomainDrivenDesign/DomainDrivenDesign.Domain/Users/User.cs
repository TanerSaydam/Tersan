using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Users;
public sealed class User : Entity
{
    private User(){}
    public User(string name, string email, string country, string city, string street, string fullAddress, decimal amount, string currency)
    {
        Name = new(name);
        Email = email;
        Address = new(country, city, street, fullAddress);
        Money = new(amount, Currency.FromCode(currency));
    }

    public Name Name { get; private set; }
    public string Email { get; private set; }
    public Address Address { get; private set; }
    public Money Money { get; private set; }

    public void Update(string name, string email, string country, string city, string street, string fullAddress, decimal amount, string currency)
    {
        Name = new(name);
        Email = email;
        Address = new(country, city, street, fullAddress);
        Money = new(amount, Currency.FromCode(currency));
    }
}

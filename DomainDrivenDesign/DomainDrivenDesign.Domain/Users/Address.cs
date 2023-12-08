namespace DomainDrivenDesign.Domain.Users;

public sealed record Address //Value Object
{
    public Address(string country, string city, string street, string fullAddress)
    {
        if(country.Length < 3)
        {
            throw new ArgumentException("Ülke alanı 3 karakterden küçük olamaz");
        }

        if (city.Length < 3)
        {
            throw new ArgumentException("Şehir alanı 3 karakterden küçük olamaz");
        }

        if (street.Length < 3)
        {
            throw new ArgumentException("Sokak alanı 3 karakterden küçük olamaz");
        }

        if (fullAddress.Length < 3)
        {
            throw new ArgumentException("Tam adres alanı 3 karakterden küçük olamaz");
        }

        Country = country;
        City = city;
        Street = street;
        FullAddress = fullAddress;
    }

    public string Country { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public string FullAddress { get; init; }
}

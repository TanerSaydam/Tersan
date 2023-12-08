namespace DomainDrivenDesign.Domain.Shared;

public sealed record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Try = new("TRY");
    private Currency(string code)
    {
        Code = code;
    }
    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(p => p.Code == code) ?? throw new ArgumentException("Geçerli bir para birimi girin");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Try };
}

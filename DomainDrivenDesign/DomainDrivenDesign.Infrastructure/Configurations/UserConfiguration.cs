using DomainDrivenDesign.Domain.Shared;
using DomainDrivenDesign.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainDrivenDesign.Infrastructure.Configurations;
public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        builder.OwnsOne(p => p.Address, addressBuilder =>
        {
            addressBuilder.Property(p => p.Country).HasColumnType("varchar(200)").HasColumnName("Country");
            addressBuilder.Property(p => p.City).HasColumnType("varchar(200)").HasColumnName("City");
            addressBuilder.Property(p => p.Street).HasColumnType("varchar(200)").HasColumnName("Street");
            addressBuilder.Property(p => p.FullAddress).HasColumnType("varchar(200)").HasColumnName("FullAddress");
        });

        builder.OwnsOne(p => p.Money, moneyBuilder =>
        {
            moneyBuilder.Property(p => p.Amount).HasColumnType("money");
            moneyBuilder.Property(p => p.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
        });
    }
}

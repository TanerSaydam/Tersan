using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Configurations;
public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasQueryFilter(x => !x.IsDeleted);

        builder.Property(p => p.Name).HasColumnType("varchar(200)").IsRequired(true);
        builder.Property(p => p.Price).HasColumnType("money").IsRequired(true);
        builder.HasIndex(x => x.Name).IsUnique(true);

    }
}

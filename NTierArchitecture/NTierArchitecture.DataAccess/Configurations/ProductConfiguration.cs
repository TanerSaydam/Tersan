using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Configurations;
internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.Property(p => p.Name).HasColumnType("varchar(200)").IsRequired(true);
        builder.Property(p => p.Price).HasColumnType("money").IsRequired(true);
        builder.HasIndex(p => p.Name).IsUnique(true);        
    }
}

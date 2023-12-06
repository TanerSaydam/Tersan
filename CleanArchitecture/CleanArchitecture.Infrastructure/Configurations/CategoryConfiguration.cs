using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Configurations;

public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasQueryFilter(x => !x.IsDeleted);

        builder.Property(p => p.Name).HasColumnType("varchar(200)").IsRequired(true);
        builder.HasIndex(x => x.Name).IsUnique(true);
    }
}

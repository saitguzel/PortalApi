using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(a=>a.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(a=>a.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(a=>a.MetaTitle).IsRequired().HasMaxLength((int)MaxLengthSize.MetaTitle);
            builder.Property(a=>a.MetaKeywords).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.Property(a=>a.MetaDescription).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.HasIndex(a=>a.Name).IsUnique();


        }
    }
}
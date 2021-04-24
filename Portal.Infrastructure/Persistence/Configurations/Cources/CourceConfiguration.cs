using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Cources
{
    public class CourceConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(x=>x.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
            builder.Property(x=>x.MetaTitle).IsRequired().HasMaxLength((int)MaxLengthSize.MetaTitle);
            builder.Property(x=>x.MetaDescription).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.Property(x=> x.MetaKeywords).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            
        }
    }
}
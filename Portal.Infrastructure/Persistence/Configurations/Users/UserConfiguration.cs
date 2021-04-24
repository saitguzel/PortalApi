using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Articles
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(z=>z.FullName).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(z=>z.Email).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            builder.HasIndex(x=>x.Email).IsUnique();
        }
    }
}
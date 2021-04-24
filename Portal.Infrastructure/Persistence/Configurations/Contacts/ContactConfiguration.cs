using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Contacts
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(a=>a.FullName).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(a=>a.EmailAddress).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            //builder.HasIndex(x=>x.EmailAddress).IsUnique();
            builder.Property(a=>a.PhoneNumber).IsRequired().HasMaxLength((int)MaxLengthSize.PhoneNumber);
            builder.Property(a=>a.Content).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
        }
    }
}
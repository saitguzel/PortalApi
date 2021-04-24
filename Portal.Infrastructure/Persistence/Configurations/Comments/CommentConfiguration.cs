using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Comments
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x=>x.ArticleId).IsRequired();
            builder.Property(x=>x.CommentText).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(x=>  x.CommenterName).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            builder.Property(x=> x.CommentEmail).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            

        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Articles
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x=>x.Title).IsRequired().HasMaxLength((int)MaxLengthSize.Title);
            builder.Property(x=>x.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
        }
    }
}
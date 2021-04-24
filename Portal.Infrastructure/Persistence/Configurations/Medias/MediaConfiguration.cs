using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Medias
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
			builder.Property(x=> new { x.FileName, x.Caption}).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
			builder.Property(x=>x.MediaType).IsRequired();
        }
    }
}
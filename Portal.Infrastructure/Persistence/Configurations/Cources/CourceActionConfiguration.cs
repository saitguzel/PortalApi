using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Cources
{
   public class CourseActionConfiguration : IEntityTypeConfiguration<CourseAction>
    {
        public void Configure(EntityTypeBuilder<CourseAction> builder)
        {
            builder.Property(s => s.UserId).IsRequired();
            builder.Property(s => s.CourseId).IsRequired();
            builder.Property(s => s.CourseLessonId ).IsRequired();
        }
    }
}
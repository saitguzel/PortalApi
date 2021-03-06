using Portal.Domain.Common;

namespace Portal.Domain.Entities
{
	public class CourseAction : BaseEntity
	{
	 
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int? CourseLessonId { get; set; }

        //public virtual CourseLesson CourseLesson { get; set; }

        public bool  IsFinished { get; set; }

	}
}
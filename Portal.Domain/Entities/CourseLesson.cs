using System.Collections.Generic;
using Portal.Domain.Common;

namespace Portal.Domain.Entities
{
	public class CourseLesson : BaseEntity
	{
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
	
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        //public virtual ICollection<CourseAction> CourseActions { get; set; }
    }
}
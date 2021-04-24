using System.Collections.Generic;
using Portal.Domain.Common;

namespace Portal.Domain.Entities
{
	public class Article : BaseEntity
	{
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
	
        public int? ThumbnailImageId { get; set; }
    
        public virtual Media ThumbnailImage { get; set; }

        public int RewiewsCount { get; set; }
    
        public double RatingAverage { get; set; }

        public bool IsPublished { get; set; }

        // bir makalenin birden fazla Media sı olabilir demek
        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }

        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    } 
}
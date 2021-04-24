using System.Collections.Generic;
using Portal.Domain.Common;

namespace Portal.Domain.Entities
{
	public class Comment : BaseEntity
	{
        public int? UserId { get; set; }
    
        public virtual User User { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public CommentStatus Status { get; set; } = CommentStatus.Pending;

        public string CommentText { get; set; }
        public string CommenterName { get; set; }
        public string CommentEmail { get; set; }

        public int? ParentId { get; set; }

        public Comment Parent { get; set; }
	
        // Yoruma ait cevapları getiren kısım
        public IList<Comment> Replies {get; protected set;} = new List<Comment>();
     
    }
}
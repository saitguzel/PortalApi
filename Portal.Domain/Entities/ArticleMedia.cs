
namespace Portal.Domain.Entities
{
	public class ArticleMedia
	{
        // many to many table
        public int ArticleId { get; set; }

        public Article Article { get; set; }
	
        public int MediaId { get; set; }
    
        public Media Media { get; set; }
    
    }
}
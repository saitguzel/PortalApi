using Microsoft.EntityFrameworkCore;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence 
{
    public class PortalDbContext : DbContext 
    {
        public PortalDbContext (DbContextOptions<PortalDbContext> options) : base (options) { }


        // veritabanı oluşturulurken çağrılır.    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleCategory>()
                        .HasKey(x=> new {x.ArticleId, x.CategoryId});
            
            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(x=>x.Article)
                        .WithMany(x=>x.ArticleCategories)
                        .HasForeignKey(x=> x.ArticleId);

            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(x=>x.Category)
                        .WithMany(x=>x.ArticleCategories)
                        .HasForeignKey(x=> x.CategoryId);

            modelBuilder.Entity<ArticleMedia>()
                        .HasKey(x=> new {x.ArticleId, x.MediaId});
            
            modelBuilder.Entity<ArticleMedia>()
                        .HasOne(x=>x.Article)
                        .WithMany(x=>x.ArticleMedias)
                        .HasForeignKey(x=> x.ArticleId);

            modelBuilder.Entity<ArticleMedia>()
                        .HasOne(x=>x.Media)
                        .WithMany(x=>x.ArticleMedias)
                        .HasForeignKey(x=> x.MediaId);



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortalDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    
    }
}
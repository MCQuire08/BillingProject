using Microsoft.EntityFrameworkCore;

namespace WebApi.Entity
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartArticle> ShoppingCartArticles { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasKey(a => a.Code);
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.User)
                .WithMany(u => u.ShoppingCarts)
                .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<ShoppingCartArticle>()
                .HasKey(sca => new { sca.CartId, sca.ArticleId });

            modelBuilder.Entity<ShoppingCartArticle>()
                .HasOne(sca => sca.ShoppingCart)
                .WithMany(sc => sc.ShoppingCartArticles)
                .HasForeignKey(sca => sca.CartId);

            modelBuilder.Entity<ShoppingCartArticle>()
                .HasOne(sca => sca.Article)
                .WithMany()
                .HasForeignKey(sca => sca.ArticleId);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.ShoppingCart)
                .WithMany()
                .HasForeignKey(b => b.CartId);
        }

    }
}

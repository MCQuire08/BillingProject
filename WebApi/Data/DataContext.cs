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

    }
}

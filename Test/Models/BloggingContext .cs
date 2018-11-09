using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           // modelBuilder.Entity<Post>()
           //.HasOne(p => p.Blog)
           //.WithMany(b => b.Posts)
           //.HasForeignKey(p => p.BlogId);
        }
    }
}

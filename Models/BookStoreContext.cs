using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Book { get; set; } = null!;
        public DbSet<Author> Author { get; set; } = null!;


        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base (options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title);
                entity.HasOne<Author>(e => e.Author);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.Surname);
            });
        }
    }
}

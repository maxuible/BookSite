using Microsoft.EntityFrameworkCore;
using BookSite.Models;


namespace BookSite.Data
{
    public class BookDbContext : DbContext 
    {
        public DbSet<Book> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
    }
}

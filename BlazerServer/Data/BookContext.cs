using Microsoft.EntityFrameworkCore;

namespace BookManagement.Data
{
    public class BookContext:DbContext
    {

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }


        public DbSet<Book> Book { get; set; }

        
    }
}

using Microsoft.EntityFrameworkCore;

namespace BookManagement.Data
{
    public class BookService
    {
        private readonly BookContext bookContext;
        

        public BookService(BookContext bookContext)
        {
            this.bookContext = bookContext;
        }

        public async Task<Book[]> GetBookListAsync()
        {
            return await bookContext.Book.ToArrayAsync();
        }


        public async Task<bool> InsertBook(Book book)
        {
            await bookContext.Book.AddAsync(book);
            await bookContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateBook(Book book)
        {
            bookContext.Book.Update(book);
            await bookContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBook(Book book)
        {
            bookContext.Remove(book);
            await bookContext.SaveChangesAsync();
            return true;
        }

        public async Task<Book> GetBookById(int id)
        {
            return await bookContext.Book.FirstOrDefaultAsync(c=>c.id.Equals(id));
        }
    }
}


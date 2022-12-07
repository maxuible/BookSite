using BookSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookSite.Data
{

    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        void SaveChanges();
    }


    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository() 
        {

        }

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }


        public virtual IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }


        public virtual void AddNewBook(Book newBook)
        {
            _context.Books.Add(newBook);
        }
    }
}

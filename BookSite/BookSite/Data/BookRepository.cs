using BookSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookSite.Data
{

    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        void SaveChanges();
        void AddNewBook(Book newBook);
        Book GetBookById(int id);
        void EditBookById(Book newEdit, int id);
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

        public virtual Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public virtual void EditBookById(Book newEdit, int id)
        {
            Book oldEdit = _context.Books.Find(id);








            oldEdit.Title = newEdit.Title;
            oldEdit.Description = newEdit.Description;
            oldEdit.Author = newEdit.Author;
            oldEdit.Isbn= newEdit.Isbn;
            oldEdit.Type= newEdit.Type;
            oldEdit.Url = newEdit.Url;
            oldEdit.Status = newEdit.Status;


            //if (testEdit!= null)
            //{
            //    testEdit.Title = "zxcv";
            //}





            
            //_context.Books.
            //Book oldEdit = GetBookById(newEdit.Id);
            //_context.Books.Remove(oldEdit);
            //_context.Books.Add(newEdit);
        }

    }
}

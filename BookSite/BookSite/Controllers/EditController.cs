using BookSite.Data;
using Microsoft.AspNetCore.Mvc;
using BookSite.Models;

namespace BookSite.Controllers
{
    public class EditController : Controller
    {

        private BookRepository _repo;

        public EditController(BookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int id)
        {
            
            Book book = _repo.GetBookById(id);
            return View(book);
        }
    }
}

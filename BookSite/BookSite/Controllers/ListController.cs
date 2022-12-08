using BookSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookSite.Data;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BookSite.Controllers
{
    public class ListController : Controller
    {
        private BookRepository _repo;

        public ListController(BookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> books = _repo.GetAllBooks();
            return View(books);
        }


        public IActionResult Details(int id)
        {
            Book thebook = _repo.GetBookById(id);

            return View(thebook);
        }
    }
}

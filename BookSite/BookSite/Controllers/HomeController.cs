using BookSite.Data;
using BookSite.Models;
using BookSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Controllers
{
    public class HomeController : Controller
    {


        private BookRepository _repo;

        public HomeController(BookRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("AddBook")]
        public IActionResult AddBook()
        {
            return View();
        }


        public IActionResult ProcessAddBook(AddBookViewModel addBookViewModel)
        {

            if (ModelState.IsValid)
            {

                Book book = new Book(addBookViewModel.Title, addBookViewModel.Description, addBookViewModel.Author,
                    addBookViewModel.Isbn, addBookViewModel.Type, addBookViewModel.Url);


                _repo.AddNewBook(book);

                _repo.SaveChanges();
                return Redirect("/List");
                
            }

            return View("AddBook", addBookViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

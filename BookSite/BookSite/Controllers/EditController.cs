using BookSite.Data;
using Microsoft.AspNetCore.Mvc;
using BookSite.Models;
using BookSite.ViewModels;
using System;
using System.Collections.Generic;

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

        public IActionResult ProcessEditBook(AddBookViewModel addBookViewModel)
        {
            if (ModelState.IsValid)
            {

                Book book = new Book(addBookViewModel.Title, addBookViewModel.Description, addBookViewModel.Author,
                    addBookViewModel.Isbn, addBookViewModel.Type, addBookViewModel.Url, addBookViewModel.Status);

                


                _repo.EditBookById(book, addBookViewModel.Id);
                _repo.SaveChanges();
                
                return Redirect("/List");

            }

            return View("AddBook", addBookViewModel);

        }


        public IActionResult Delete(int id)
        {

            _repo.DeleteBookById(id);
            _repo.SaveChanges();
            return Redirect("/List");
        }
    }
}

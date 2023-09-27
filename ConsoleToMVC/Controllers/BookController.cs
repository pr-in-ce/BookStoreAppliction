using ConsoleToMVC.Models;
using ConsoleToMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Controllers
{
    public class BookController : Controller
    {
        //Made a constructor
        private readonly BookRepository _bookRepository = null;
        //Create the instance 
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBook(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string Bookname, string AuthorName)
        {
            return _bookRepository.SearchBook(Bookname, AuthorName);
        }

        public List<BookModel> GetBookByPage(int NoOfPages)
        {
            return _bookRepository.GetBookByPage(NoOfPages);
        }


        public ViewResult AddNewBook(bool isSuccess = false, int bookId=0 )
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(BookModel bookModel)
        {
           int id = _bookRepository.AddNewBook(bookModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewBook) , new { isSuccess= true});
            }
            return View();
        }
    }
}





/*if (ModelState.IsValid)
{
    _bookRepository.AddNewBook(bookModel);
    return View();
}
else
{
    return View();
}*/
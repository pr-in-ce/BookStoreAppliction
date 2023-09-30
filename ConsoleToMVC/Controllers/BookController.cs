using ConsoleToMVC.Models;
using ConsoleToMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleToMVC.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        [Route("book-details/{id}", Name = "bookDetailRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);
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
        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", " this is my first custom error message");
                ModelState.AddModelError("", " this is my second custom error message");
                return View();
            }
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
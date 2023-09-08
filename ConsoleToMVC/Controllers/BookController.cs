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
        private readonly BookRepository _bookRepository= null;

        //Create the instance 
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string Bookname, string AuthorName)
        {
            return _bookRepository.SearchBook(Bookname , AuthorName);
        }

        public List<BookModel> GetBookByPage(int NoOfPages)
        {
            return _bookRepository.GetBookByPage(NoOfPages);
        }
    }
}

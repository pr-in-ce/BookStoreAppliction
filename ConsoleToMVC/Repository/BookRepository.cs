using ConsoleToMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }
        public List<BookModel> GetBookByPage(int noOfPages)
        {
            return DataSource().Where(x => x.NoOfPages == noOfPages).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "Mvc" , Author = "Nitish" , NoOfPages= 34},
                new BookModel(){Id = 2, Title = "java" , Author = "Prince" , NoOfPages= 64 },
                new BookModel(){Id = 3, Title = "C#" , Author = "Vivek" , NoOfPages= 24},
                new BookModel(){Id = 4, Title = "JavaScript" , Author = "joy" , NoOfPages= 85},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65}
            };
        }
    }
}

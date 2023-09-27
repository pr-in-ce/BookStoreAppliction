using ConsoleToMVC.Data;
using ConsoleToMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToMVC.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context) 
        {
            _context = context; 
        }
        public int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdateOn = DateTime.UtcNow
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBook(int id)
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
                new BookModel(){Id = 1, Title = "Mvc" , Author = "Nitish" , NoOfPages= 34 , Description="Description of MVC" , Category="Programming" , Language = "English" , TotalPages= 134},
                new BookModel(){Id = 2, Title = "java" , Author = "Prince" , NoOfPages= 64, Description="Description of Java" , Category="Programming" , Language = "English" , TotalPages= 634 },
                new BookModel(){Id = 3, Title = "C#" , Author = "Vivek" , NoOfPages= 24, Description="Description of C#" , Category="Programming" , Language = "English" , TotalPages= 546},
                new BookModel(){Id = 4, Title = "JavaScript" , Author = "joy" , NoOfPages= 85, Description="Description of JavaScript" , Category="Programming" , Language = "English" , TotalPages= 345},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
                new BookModel(){Id = 5, Title = "Python" , Author = "Sourabh" , NoOfPages= 65, Description="Description of Python" , Category="Programming" , Language = "English" , TotalPages= 435},
            };
        }
    }
}

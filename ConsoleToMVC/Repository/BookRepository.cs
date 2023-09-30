using ConsoleToMVC.Data;
using ConsoleToMVC.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<int> AddNewBook(BookModel model)
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
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allBooks = await _context.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach(var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        Author=book.Author,
                        Category=book.Category,
                        Description=book.Description,
                        Id=book.Id,
                        Language=book.Language,
                        Title=book.Title,
                        TotalPages=book.TotalPages
                    });
                }
            }
            return books;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                var bookDetails = new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    Language = book.Language,
                    Title = book.Title,
                    TotalPages = book.TotalPages
                };
                return bookDetails;
            }
            return null;
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

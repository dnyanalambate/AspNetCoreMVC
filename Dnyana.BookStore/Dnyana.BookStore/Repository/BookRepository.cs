using Dnyana.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnyana.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x =>x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="C#", Author="Dnyana"},
                new BookModel(){Id=2, Title="Java", Author="Hari"},
                new BookModel(){Id=3, Title="C++", Author="Akshay"},
                new BookModel(){Id=4, Title="Python", Author="Ashutosh"}
            };
        }
    }
}

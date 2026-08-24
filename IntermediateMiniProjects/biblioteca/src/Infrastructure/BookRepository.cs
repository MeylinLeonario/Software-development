using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Domain.Models;

namespace biblioteca.src.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public List<Book> getAll()
        {
            return books;
        }
    }
}
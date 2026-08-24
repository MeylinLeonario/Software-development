using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Domain.Models;

namespace biblioteca.src.Infrastructure
{
    public interface IBookRepository
    {
        public void Add(Book book);
        public List<Book> getAll();
    }
}
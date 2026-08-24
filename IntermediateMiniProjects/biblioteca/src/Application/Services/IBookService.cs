using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;
using biblioteca.src.Domain.Models;

namespace biblioteca.src.Application.Services
{
    public interface IBookService
    {
        public Book AddBook(BookDTO dto);
        public List<Book> ListAvailability();
    }
}
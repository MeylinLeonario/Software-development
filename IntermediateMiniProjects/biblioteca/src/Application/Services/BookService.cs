using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;
using biblioteca.src.Domain.Models;
using biblioteca.src.Infrastructure;

namespace biblioteca.src.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book AddBook(BookDTO dto)
        {
            BookValidation(dto);
            Book book = new Book(
                dto.id,
                dto.title,
                dto.author,
                dto.isAvailable
            );

            _bookRepository.Add(book);
            return book;
        }

        public List<Book> ListAvailability()
        {
            List<Book> books = _bookRepository.getAll();
            List<Book> availables = new List<Book>();

            foreach(Book book in books)
            {
                if (book.isAvailable)
                {
                    availables.Add(book);
                }
            }
            return availables;
        }

        private void BookValidation(BookDTO bookDTO)
        {
            if (bookDTO.title is null)
            {
                throw new ArgumentException("El titulo no puede ser nulo");
            }
            if (bookDTO.author is null)
            {
                throw new ArgumentException("El autor no puede ser nulo");
            }
        }
    }
}
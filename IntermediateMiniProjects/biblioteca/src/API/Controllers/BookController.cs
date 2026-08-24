using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;
using biblioteca.src.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace biblioteca.src.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO dto)
        {
            var book = _bookService.AddBook(dto);
            return Ok(book);
        }

        [HttpGet]
        public IActionResult ListAvailability()
        {
            _bookService.ListAvailability();
            return Ok();
        }
    }
}
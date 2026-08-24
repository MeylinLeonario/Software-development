using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;
using biblioteca.src.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace biblioteca.src.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public IActionResult CreateLoan(LoanDTO loandto, BookDTO bookdto)
        {
            _loanService.CreateLoan(loandto, bookdto);
            return Ok();
        }

        [HttpPatch]
        public IActionResult ReturnBook(BookDTO dto)
        {
            _loanService.ReturnBook(dto);
            return Ok();
        }
    }
}
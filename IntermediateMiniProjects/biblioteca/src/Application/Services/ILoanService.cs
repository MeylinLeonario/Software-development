using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;

namespace biblioteca.src.Application.Services
{
    public interface ILoanService
    {
        public void CreateLoan(LoanDTO loan, BookDTO bookDto);
        public void ReturnBook(BookDTO bookdto);
    }
}
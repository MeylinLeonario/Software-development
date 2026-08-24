using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Application.DTOs;
using biblioteca.src.Domain.Models;
using biblioteca.src.Infrastructure;

namespace biblioteca.src.Application.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        public LoanService(ILoanRepository loanRepository, IBookRepository bookRepository)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
        }

        public void CreateLoan(LoanDTO loandto, BookDTO bookDto)
        {
            ValidateLoan(loandto);
            
            Loan loan = new Loan(
                loandto.id,
                bookDto.id,
                loandto.borrowerName,
                loandto.loanDate,
                loandto.returnDate
            );

            _loanRepository.CreateLoan(loan);
        }

        public void ReturnBook(BookDTO bookdto)
        {
            List<Book> books = _bookRepository.getAll();
            List<BookDTO> booksDTO = new List<BookDTO>();

            foreach (Book book in books)
            {
                if (book.id == bookdto.id)
                {
                    bookdto.isAvailable = true;
                }
            }
            
        }

        private void ValidateLoan(LoanDTO dto)
        {
            if (dto.borrowerName is null)
            {
                throw new ArgumentNullException("El nombre del prestador es nulo.");
            }
        }
    }
}
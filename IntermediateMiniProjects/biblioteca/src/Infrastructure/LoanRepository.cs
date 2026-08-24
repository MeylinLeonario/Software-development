using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.src.Domain.Models;

namespace biblioteca.src.Infrastructure
{
    public class LoanRepository : ILoanRepository
    {
        private readonly IBookRepository _bookRepository;
        public LoanRepository(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Loan> loans = new List<Loan>();

        public void CreateLoan(Loan loan)
        {
            loans.Add(loan);
        }
    }
}
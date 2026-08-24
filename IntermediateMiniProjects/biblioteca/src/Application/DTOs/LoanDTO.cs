using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.src.Application.DTOs
{
    public class LoanDTO
    {
        public int id {get;set;}
        public int bookId {get;set;}
        public string borrowerName {get;set;}
        public DateOnly loanDate {get;set;}
        public DateOnly returnDate {get;set;}

        public LoanDTO(int id, int bookId, string borrowerName, DateOnly loanDate, DateOnly returnDate)
        {
            this.id = id;
            this.bookId = bookId;
            this.borrowerName=borrowerName;
            this.loanDate = loanDate;
            this.returnDate = returnDate;
        }
    }
}
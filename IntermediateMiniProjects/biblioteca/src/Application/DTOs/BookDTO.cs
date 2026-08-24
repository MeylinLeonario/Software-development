using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.src.Application.DTOs
{
    public class BookDTO
    {
        public int id {get; set;}
        public string title {get; set;}
        public string author {get; set;}
        public bool isAvailable {get; set;}

        public BookDTO(int Id, string Title, string Author, bool IsAvailable)
        {
            this.id = Id;
            this.title = Title;
            this.author = Author;
            this.isAvailable = IsAvailable;
        }
    }
}
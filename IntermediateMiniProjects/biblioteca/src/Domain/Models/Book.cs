using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.src.Domain.Models
{
    public class Book
    {
        public int id {get; set;}
        public string title {get; set;}
        public string author {get; set;}
        public bool isAvailable {get; set;}

        public Book(int Id, string Title, string Author, bool IsAvailable)
        {
            this.id = Id;
            this.title = Title;
            this.author = Author;
            this.isAvailable = IsAvailable;
        }
    }
}
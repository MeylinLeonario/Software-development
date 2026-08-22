using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.src.Application.DTOs
{
    public class CreateTaskDTO
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public bool IsCompleted {get; set;}
    }
}
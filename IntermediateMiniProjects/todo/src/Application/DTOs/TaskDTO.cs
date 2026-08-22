using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.src.Application.DTOs
{
    public class TaskDTO
    {
        public TaskDTO(int id, string name, bool isCompleted)
        {
            this.id = id;
            this.name = name;
            this.isCompleted = isCompleted;
        }

        public int id {get; set;}
        public string name {get; set;}
        public bool isCompleted {get; set;}
    }
}
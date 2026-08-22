using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.src.Domain.Models
{
    public class TaskItem
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public bool IsCompleted {get; set;}

        public TaskItem(int id, string name, bool isCompleted)
        {
            Id = id;
            Name = name;
            IsCompleted = isCompleted;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.Domain.Enums;

namespace backend.api.src.Domain.Models
{
    public class TaskItem
    {
        public int id {get;set;}
        public string title {get;set;}
        public string description {get;set;}
        public DateOnly deadline {get;set;}
        public Priority priority {get;set;}
        public bool isCompleted;

        public TaskItem(){}

        public TaskItem(
        string title,
        string description,
        DateOnly deadline,
        Priority priority)
        {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.priority = priority;
        }
    }
}
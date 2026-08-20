using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_7.Models
{
    public class TaskItem
    {
        public int id { get; set; }
        public string nombreTarea { get; set; }
        public bool isCompleted { get; set; }

        public TaskItem(int id, string nombreTarea, bool isCompleted)
        {
            this.id = id;
            this.nombreTarea = nombreTarea;
            this.isCompleted = isCompleted;
        }
    }
}
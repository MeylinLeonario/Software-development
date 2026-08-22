using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.src.Domain.Models;

namespace todo.src.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        public List<TaskItem> getAll()
        {
            return tasks;
        }

        public void Delete(TaskItem task)
        {
            tasks.Remove(task);
        }

        public void Change(TaskItem task)
        {
            task.IsCompleted = true;
        }
    }
}
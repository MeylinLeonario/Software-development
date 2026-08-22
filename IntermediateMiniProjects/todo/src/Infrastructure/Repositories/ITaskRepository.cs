using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.src.Domain.Models;

namespace todo.src.Infrastructure.Repositories
{
    public interface ITaskRepository
    {

        public void Add(TaskItem task);

        public List<TaskItem> getAll();

        public void Delete(TaskItem task);

        public void Change(TaskItem task);

    }
}
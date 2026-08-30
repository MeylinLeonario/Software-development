using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.Domain.Models;


namespace backend.api.src.infrastructure.Repository
{
    public interface ITaskItemRepository
    {
        public Task Create(TaskItem taskItem);
        public Task<List<TaskItem>> List();
        public Task Review(TaskItem taskItem);
        public Task Edit(TaskItem taskItem);
        public Task Delete(TaskItem taskItem);
    }
}
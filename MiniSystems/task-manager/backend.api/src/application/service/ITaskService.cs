using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.application.dtos;
using backend.api.src.Domain.Models;

namespace backend.api.src.application.service
{
    public interface ITaskService
    {
        public Task CreateTask(CreateTaskItemDTO dto);
        public Task<List<TaskItem>> ListTasks();
        public Task<TaskItem> ReviewTask();
        public Task EditTask();
        public Task DeleteTask();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.application.dtos;
using backend.api.src.Domain.Models;
using backend.api.src.infrastructure.Repository;

namespace backend.api.src.application.service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskItemRepository _taskItemRepository;
        public TaskService(ITaskItemRepository repository)
        {
            _taskItemRepository = repository;
        }
        public async Task CreateTask(CreateTaskItemDTO dto)
        {
            TaskItem task = new TaskItem(
                dto.title,
                dto.description,
                dto.deadline,
                dto.priority
            );

            await _taskItemRepository.Create(task);

        }

        public async Task DeleteTask(DeleteTaskDTO dto)
        {
            List<TaskItem> tasks = await _taskItemRepository.List();
            foreach (TaskItem task in tasks)
            {
                if (dto.id == task.id)
                {
                    await _taskItemRepository.Delete(task);
                }
            }
        }

        public async Task EditTask(EditTaskItemDTO dto)
        {
            List<TaskItem> tasks = await _taskItemRepository.List();
            foreach (TaskItem task in tasks)
            {
                TaskItem newTask = new TaskItem
                    (
                        dto.title,
                        dto.description,
                        dto.deadline,
                        dto.priority
                    );

                await _taskItemRepository.Edit(newTask);
            }
        }

        public async Task<List<TaskItem>> ListTasks()
        {
            List<TaskItem> tasks = await _taskItemRepository.List();
            return tasks;
        }

        public async Task<TaskItem> ReviewTask(int id)
        {
            TaskItem? task = await _taskItemRepository.Review(id);
            return task;
        }
    }
}
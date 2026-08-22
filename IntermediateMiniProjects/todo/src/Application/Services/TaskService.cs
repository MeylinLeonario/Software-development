using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.src.Application.DTOs;
using todo.src.Domain.Models;
using todo.src.Infrastructure.Repositories;

namespace todo.src.Application.Services
{
    public class TaskService : ITaskService
    {

        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public bool CompleteTask(TaskDTO dto)
        {
            List<TaskItem> tasks = _taskRepository.getAll();

            foreach (TaskItem task in tasks)
            {
                if (task.Id == dto.id)
                {
                    task.IsCompleted = true;
                    _taskRepository.Change(task);
                    return true;
                }
            }
            return false;
        }

        public TaskDTO CreateTask(CreateTaskDTO dto)
        {
            ValidateTask(dto);
            TaskItem taskItem = new TaskItem(
                dto.Id,
                dto.Name,
                false
            );

            _taskRepository.Add(taskItem);
            return new TaskDTO(taskItem.Id, taskItem.Name, taskItem.IsCompleted);
        }

        public void EliminarTask(DeleteTaskDTO dto)
        {
            List<TaskItem> tasks = _taskRepository.getAll();

            TaskItem? taskToDelete = null;

            foreach (TaskItem task in tasks)
            {
                if (task.Id == dto.id)
                {
                    taskToDelete = task;
                }
            }

            if (taskToDelete != null)
            {
                _taskRepository.Delete(taskToDelete);
            }
        }

        public List<ListarTareasDTO> ListarTareas()
        {
            List<TaskItem> tasks = _taskRepository.getAll();
            List<ListarTareasDTO> taskDTOs = new List<ListarTareasDTO>();
            
            foreach (TaskItem task in tasks)
            {
                ListarTareasDTO dto = new ListarTareasDTO
                {
                    id = task.Id,
                    name = task.Name,
                    isCompleted = task.IsCompleted
                };

                taskDTOs.Add(dto);
            }

            return taskDTOs;
        }

        private void ValidateTask(CreateTaskDTO dto)
        {
            if (dto.Name is null)
            {
                throw new ArgumentException("El nombre es obligatorio.");

            }
        }
    }
}
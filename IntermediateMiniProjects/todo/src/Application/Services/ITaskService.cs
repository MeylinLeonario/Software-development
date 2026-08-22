using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.src.Application.DTOs;

namespace todo.src.Application.Services
{
    public interface ITaskService
    {
        public TaskDTO CreateTask(CreateTaskDTO dto);
        public List<ListarTareasDTO> ListarTareas();
        public bool CompleteTask(TaskDTO dto);

        public void EliminarTask(DeleteTaskDTO dto);
    }
}
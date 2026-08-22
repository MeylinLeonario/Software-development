using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo.src.Application.DTOs;
using todo.src.Application.Services;


namespace todo.src.API.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetTask()
        {
            var tasks = _taskService.ListarTareas();
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] CreateTaskDTO dto)
        {
            var task = _taskService.CreateTask(dto);
            return Ok(task);
        }

        [HttpPatch]
        public IActionResult CompleteTask(TaskDTO dto)
        {
            var task = _taskService.CompleteTask(dto);
            return Ok(task);
        }

        [HttpDelete]
        public IActionResult DeleteTask (DeleteTaskDTO dto)
        {
            _taskService.EliminarTask(dto);
            return Ok();
        }
    }
}
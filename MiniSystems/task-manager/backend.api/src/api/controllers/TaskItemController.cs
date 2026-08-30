using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.application.dtos;
using backend.api.src.application.service;
using Microsoft.AspNetCore.Mvc;

namespace backend.api.src.api.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskService _service;
        public TaskItemController (ITaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> ListTasks()
        {
            var tasks = await _service.ListTasks();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(CreateTaskItemDTO dto)
        {
             await _service.CreateTask(dto);
             return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTask(int id)
        {
            var task = await _service.ReviewTask(id);
            return Ok(task);
        }

        [HttpPatch]
        public async Task<ActionResult> EditTask(EditTaskItemDTO dto)
        {
            await _service.EditTask(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTask(DeleteTaskDTO dto)
        {
            await _service.DeleteTask(dto);
            return Ok();
        }
    }
}
using Clase3Modulo3.Services.Interfaces;
using EjercicioModulo3Clase2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Clase3Modulo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITasksServices tasksServices;

        public TasksController(ITasksServices tasksServices)
        {
            this.tasksServices = tasksServices;
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            var result = tasksServices.getTasks();
            return Ok(result);
        }

        [HttpGet("/{id}")]
        public ActionResult getTaskById([FromRoute] int id)
        {
            var result = tasksServices.getTaskById(id);
            if (result != null) return Ok(result);
            else return BadRequest();
        }

        [HttpPost]
        public ActionResult saveTask([FromBody] Tasks task)
        {
            tasksServices.saveTask(task);
            return Ok();
        }

        [HttpPut("/complete/{id}")]
        public ActionResult putCompleteTask([FromRoute] int id)
        {
            var result = tasksServices.putCompleteTask(id);
            if (result != null) return Ok(result);
            else return BadRequest();
        }

        [HttpPut("/logic-delete/{id}")]
        public ActionResult putDarBaja([FromRoute] int id)
        {
            var result = tasksServices.putDarBaja(id);
            if (result != null) return Ok(result);
            else return BadRequest();
        }
    }
}

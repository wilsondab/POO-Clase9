using EjercicioModulo3Clase2.Domain.Entities;
using EjercicioModulo3Clase2.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EjercicioModulo3Clase2.Controllers
{
    [Route( "" )]
    [ApiController]
    public class TaskController : ControllerBase
    {
        #region Pasos previos
        /*
         * 1 - Instalar EF Core y EF Core SQL Server
         * 2 - Crear contexto de base de datos y los modelos. Se puede usar Ingenieria Inversa de EF Core Power Tools
         * 3 - Configurar la inyección de dependencia del contexto tanto en Program.cs como en el controlador. No olvidar el string de conexión.
         * 4 - Las rutas de los endpoints queda a criterio de cada uno.
         * 5 - En este controlador, realizar los siguientes ejercicios:
         */
        #endregion

        private ToDoListDBContext context;

        public TaskController(ToDoListDBContext context)
        {
            this.context = context;
        }

        #region Ejercicio 1
        // Crear un endpoint para obtener un listado de todas las tareas usando HTTP GET

        [HttpGet]
        public ActionResult getTask()
        {
            return Ok(context.Tasks.ToList());
        }

        #endregion

        #region Ejercicio 2
        // Crear un endpoint para obtener una tarea por ID usando HTTP GET

        [HttpGet("/{id}")]
        public ActionResult getTaskById([FromRoute] int id)
        {
            var result = context.Tasks.Where(x => x.Id == id);
            if (result.Any()) return Ok(result);
            else return BadRequest();
        }

        #endregion

        #region Ejercicio 3
        // Crear un endpoint para crear una nueva tarea usando HTTP POST

        [HttpPost]
        public ActionResult saveTask([FromBody] Tasks task)
        {
            context.Add(task);
            context.SaveChanges();
            return Ok();
        }

        #endregion

        #region Ejercicio 4
        // Crear un endpoint para marcar una tarea como completada usando HTTP PUT

        [HttpPut("/complete/{id}")]
        public ActionResult putCompleteTask([FromRoute] int id)
        {
            var task = context.Tasks.FirstOrDefault(x => x.Id == id);
            if (task == null) return BadRequest();
            else {
                task.IsCompleted = true;
                context.SaveChanges();
                return Ok(task);
            }
        }

        #endregion

        #region Ejercicio 5
        // Crear un endpoint para dar de baja una tarea usando HTTP PUT (baja lógica)

        [HttpPut("/logic-delete/{id}")]
        public ActionResult putDarBaja([FromRoute] int id)

        {
            var task = context.Tasks.FirstOrDefault(task => task.Id == id);
            if (task == null) return BadRequest();
            else
            {
                task.IsActive = false;
                context.SaveChanges();
                return Ok(task);
            }
        }

        #endregion
    }
}

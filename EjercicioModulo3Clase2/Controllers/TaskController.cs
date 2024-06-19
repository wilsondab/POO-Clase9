using Microsoft.AspNetCore.Mvc;

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
         */
        #endregion

        #region Ejercicio 1
        // Crear un endpoint para obtener un listado de todas las tareas usando HTTP GET
        #endregion

        #region Ejercicio 2
        // Crear un endpoint para obtener una tarea por ID usando HTTP GET
        #endregion

        #region Ejercicio 3
        // Crear un endpoint para crear una nueva tarea usando HTTP POST
        #endregion

        #region Ejercicio 4
        // Crear un endpoint para marcar una tarea como completada usando HTTP PUT
        #endregion
        #region Ejercicio 5
        // Crear un endpoint para dar de baja una tarea usando HTTP PUT
        #endregion
    }
}

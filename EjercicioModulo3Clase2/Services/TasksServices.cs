using Clase3Modulo3.Services.Interfaces;
using EjercicioModulo3Clase2.Domain.Entities;
using EjercicioModulo3Clase2.Repository;

namespace Clase3Modulo3.Services
{
    public class TasksServices : ITasksServices
    {

        private ToDoListDBContext context;

        public TasksServices(ToDoListDBContext context)
        {
            this.context = context;
        }

        public List<Tasks> getTasks()
        {
            return context.Tasks.ToList();
        }

        public Tasks getTaskById(int id)
        {
            var result = context.Tasks.Where(x => x.Id == id);
            if (result.Any()) return result.First();
            else return null;
        }

        public void saveTask(Tasks task)
        {
            context.Add(task);
            context.SaveChanges();
        }

        public Tasks putCompleteTask(int id)
        {
            var task = context.Tasks.FirstOrDefault(x => x.Id == id);
            if (task == null) return null;
            else
            {
                task.IsCompleted = true;
                context.SaveChanges();
                return task;
            }
        }

        public Tasks putDarBaja(int id)

        {
            var task = context.Tasks.FirstOrDefault(task => task.Id == id);
            if (task == null) return null;
            else
            {
                task.IsActive = false;
                context.SaveChanges();
                return task;
            }
        }

    }
}

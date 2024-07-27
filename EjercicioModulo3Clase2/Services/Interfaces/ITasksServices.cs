using EjercicioModulo3Clase2.Domain.Entities;

namespace Clase3Modulo3.Services.Interfaces
{
    public interface ITasksServices
    {
        public List<Tasks> getTasks();
        public Tasks getTaskById(int id);
        public void saveTask(Tasks task);
        public Tasks putCompleteTask(int id);
        public Tasks putDarBaja(int id);

    }
}

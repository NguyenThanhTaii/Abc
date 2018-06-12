using DTO;
using System.Collections.Generic;

namespace DAO
{
    public interface ITaskDAO
    {
        IEnumerable<Task> LoadTask();
        void AddNew(Task Task);
        void UpdateTask(Task Task);
        void DeleteTask(Task Task);
    }
}
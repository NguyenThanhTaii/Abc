using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class TaskBUS
    {

        public IList<Task> Tasks { get; set; }
        private ITaskDAO TaskDAO;

        public TaskBUS(int saveAt)
        {
            GetTaskDAO(saveAt);
            Tasks = TaskDAO.LoadTask().ToList();
        }

        private void GetTaskDAO(int saveAt)
        {
            if (saveAt==1)
                TaskDAO = new TaskDAOFileSystem();

            if (saveAt==2)
                TaskDAO = new TaskDAOSql();
        }

        public IEnumerable<Task> LoadTask()
        {
            return TaskDAO.LoadTask();
        }

        public void AddNewTask(Task Task)
        {
            TaskDAO.AddNew(Task);
        }

        public void UpdateTask(Task Task)
        {
            TaskDAO.UpdateTask(Task);
        }

        public void DeleteTask(Task Task)
        {
            TaskDAO.DeleteTask(Task);
        }


        public bool HasErrors(Task task)
        {
            if (task.Title == string.Empty ||
                task.Description == string.Empty ||
                task.DateCreate.Year < 1990 ||
                task.DateFinish.Year > 2100 ||
                task.DateFinish < task.DateCreate ||
                TitleDuplicate(task, Tasks)
                )
                return true;

            return false;
        }

        public bool TitleDuplicate(Task newTask, IList<Task> listTask)
        {
            return listTask.Any(x => x.Title == newTask.Title && x.Status.Equals(newTask.Status));
        }

    }
}

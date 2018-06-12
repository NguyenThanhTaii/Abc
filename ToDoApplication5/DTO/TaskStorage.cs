using System.Collections.Generic;
using System.Windows.Forms;

namespace DTO
{
    public class TaskStorage
    {
        public IList<Task> Tasks { get; set; }

        public TaskStorage()
        {
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public Status UpdateStatus(Task task, ListBox listbox)
        {
            if (listbox.Name == "lstBacklog")
            {
                return Status.Backlog;
            }
            if (listbox.Name == "lstResolved")
            {
                return Status.Resolved;
            }
            if (listbox.Name == "lstClosed")
            {
                return Status.Closed;
            }
            return task.Status;
        }
    }
}

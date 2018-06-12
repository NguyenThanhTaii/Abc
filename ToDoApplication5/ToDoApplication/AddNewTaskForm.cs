using BUS;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class AddNewTaskForm : Form
    {

        private TaskBUS taskBusObj;
        public TaskStorage ListTask { get; set; }

        public AddNewTaskForm(int saveAt)
        {
            ListTask = new TaskStorage();
            taskBusObj = new TaskBUS(saveAt);
            ListTask.Tasks = taskBusObj.LoadTask().ToList();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text))
            {
                if (MessageBox.Show("Data not save, do you want close?.", "Warning Message",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Close();
            }
            else
                Close();
        }

        private Task GetNewTask()
        {
            return new Task()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DateCreate = dtmDateCreate.Value,
                DateFinish = dtmDateFinish.Value,
                Status = Status.Backlog
            };
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            var _newTask=GetNewTask();
            if (!taskBusObj.HasErrors(_newTask))
            {
                taskBusObj.AddNewTask(_newTask);
                MessageBox.Show("Add task success");
                Close();
            }
            else
                DisplayErrorMessage(GetNewTask());
        }

        private void DisplayErrorMessage(Task task)
        {
            if (task.Title == string.Empty)
                lblTitleNull.Visible = true;

            if (task.Description == string.Empty)
                lblDesNull.Visible = true;

            if (task.DateCreate.Year < 1990 || task.DateFinish.Year > 2100)
                MessageBox.Show("Date create >1990 or date finish < 2100");

            if (task.DateFinish < task.DateCreate)
                lblFinishdateEarlier.Show();

            if (taskBusObj.TitleDuplicate(task, ListTask.Tasks))
                MessageBox.Show("Title is already exist");
        }

        private void AddNewTaskForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            txtDescription.Text = "";
            txtTitle.Text = "";
            dtmDateCreate.Value = DateTime.Now;
            dtmDateFinish.Value = DateTime.Now;
        }

    }

}

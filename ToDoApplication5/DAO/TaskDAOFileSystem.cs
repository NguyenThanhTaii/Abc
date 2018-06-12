using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace DAO
{
    public class TaskDAOFileSystem : ITaskDAO
    {

        private string path = Utility.GetFilePath();

        private DataTable ReadFile(string xName)
        {
            var dataSet = new DataSet();
            dataSet.ReadXml(path);
            var datatable = new DataTable();
            datatable = dataSet.Tables[xName];

            return datatable;
        }

        public IEnumerable<Task> LoadTask()
        {
            var xName="Task";
            var datatable=ReadFile(xName);
            var tasks = (from row in datatable.AsEnumerable()
                         select new Task()
                         {
                             ID = Convert.ToInt32(row["ID"]),
                             Title=Convert.ToString(row["Title"]),
                             Description = Convert.ToString(row["Description"]),
                             DateCreate=Convert.ToDateTime(row["DateCreate"]),
                             DateFinish=Convert.ToDateTime(row["DateFinish"]),
                             Status=(Status)(Enum.Parse(typeof(Status),row.Field<string>("Status")))
                         });
            return tasks;
        }

        public void Insert(XElement task, string xName)
        {
            var testXML = XDocument.Load(path);
            testXML.Element(xName).Add(task);
            testXML.Save(path);
        }

        public void AddNew(Task Task)
        {
            var xName="Tasks";
            var idRandom=new Random();
            var time=DateTime.Now.Hour+DateTime.Now.Minute+DateTime.Now.Second+DateTime.Now.Millisecond;
            var newId=idRandom.Next(1,ushort.MaxValue)+time;
            var newTask = new XElement("Task",
                  new XElement("Title", Task.Title),
                  new XElement("Description",Task.Description),
                  new XElement("DateCreate",Task.DateCreate),
                  new XElement("DateFinish",Task.DateFinish),
                  new XElement("Status",Task.Status)
                  );
            newTask.SetAttributeValue("ID", newId);

            Insert(newTask, xName);
        }

        public void DeleteTask(Task Task)
        {
            var textXML = XDocument.Load(path);
            //Check if the task list after delete null, user can not delete the last task
            if (textXML.Descendants("Task").Count()>1)
            {
                var task = textXML.Descendants("Task").Where(c => (int)c.Attribute("ID")==Task.ID);
                task.Remove();
                textXML.Save(path);
            }
        }

        public void UpdateTask(Task Task)
        {
            var textXML = XDocument.Load(path);
            var task = textXML.Descendants("Task").FirstOrDefault(c => (int)c.Attribute("ID")==Task.ID);
            task.Element("Status").Value = Task.Status.ToString();
            textXML.Save(path);
        }

    }
}

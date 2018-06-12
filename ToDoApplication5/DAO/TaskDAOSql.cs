using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class TaskDAOSql : ITaskDAO
    {

        private string connstring = Utility.GetConnectionString();

        public void InsertUpdateDelete(string sqlstring, SqlParameter[] parameters)
        {
            var sqlconnection = new SqlConnection(connstring);
            sqlconnection.Open();
            var sqlcommand = new SqlCommand(sqlstring, sqlconnection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddRange(parameters);
            sqlcommand.ExecuteNonQuery();
        }

        public void AddNew(Task Task)
        {
            var dataset = new DataSet();
            var parameters=new SqlParameter[]
            {
                new SqlParameter("@title", Task.Title),
                new SqlParameter("@description", Task.Description),
                new SqlParameter("@dateCreate", Task.DateCreate),
                new SqlParameter("@dateFinish", Task.DateFinish),
                new SqlParameter("@Status", Task.Status),
            };
            var nameProcedure = "spAddNewTask";
            InsertUpdateDelete(nameProcedure, parameters);
        }



        public void DeleteTask(Task Task)
        {
            var dataset = new DataSet();
            var parameters=new SqlParameter[]
            {
                new SqlParameter("@id", Task.ID),
            };
            var nameProcedure = "spDeleteTask";
            InsertUpdateDelete(nameProcedure, parameters);
        }

        public void UpdateTask(Task Task)
        {
            var dataset = new DataSet();
            var parameters=new SqlParameter[]
            {
                new SqlParameter("@title", Task.Title),
                new SqlParameter("@description", Task.Description),
                new SqlParameter("@dateCreate", Task.DateCreate),
                new SqlParameter("@dateFinish", Task.DateFinish),
                new SqlParameter("@Status", Task.Status.ToString()),
                new SqlParameter("@id", Task.ID),
            };
            var nameProcedure = "spUpdateTask";
            InsertUpdateDelete(nameProcedure, parameters);
        }

        private DataSet ExecuteSqlString(string procedureString)
        {
            var sqlconnection = new SqlConnection(connstring);
            sqlconnection.Open();
            var dataset = new DataSet();
            var sqlcommand = new SqlCommand(procedureString, sqlconnection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            var sqladapter = new SqlDataAdapter(sqlcommand);
            sqladapter.Fill(dataset);
            return dataset;
        }


        public IEnumerable<Task> LoadTask()
        {
            var dataset = new DataSet();
            var sql = "spGetAllTask";
            dataset = ExecuteSqlString(sql);
            var taskList=dataset.Tables[0].AsEnumerable().Select(dataRow=>new Task()
            {
                ID =dataRow.Field<int>("ID"),
                Title=dataRow.Field<string>("TiTle"),
                Description =dataRow.Field<string>("Description"),
                DateCreate=dataRow.Field<DateTime>("DateCreate"),
                DateFinish=dataRow.Field<DateTime>("DateFinish"),
                Status=(Status)(Enum.Parse(typeof(Status),dataRow.Field<string>("Status")))
            });
           // var tasks=taskList.ToList();
            return taskList;
        }

    }
}

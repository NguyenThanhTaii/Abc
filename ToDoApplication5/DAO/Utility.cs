using System.Configuration;

namespace DAO
{
    public class Utility
    {

        public static string GetFilePath()
        {

            string returnValue = null;

            var settings =
            ConfigurationManager.AppSettings["filePath"];

            if (settings != null)
                returnValue = settings.ToString();

            return returnValue;
        }

        public static string GetConnectionString()
        {

            string returnValue = null;

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["ToDoApplication.Properties.Settings.connString"];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}

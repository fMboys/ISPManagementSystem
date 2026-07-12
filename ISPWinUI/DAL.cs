using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ISPWinUI
{
    public class DAL
    {
        public string GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ISPDBConnectionString"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string 'ISPDBConnectionString' not found in App.config.");
            return connectionString;

            //string connectionString = ConfigurationManager.AppSettings.Get("ISPDBConnectionString").ToString();
            ////return "Data Source=localhost;Initial Catalog=ISPWinUI;Integrated Security=True;TrustServerCertificate=True";
            //return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ISPWinUI;Integrated Security=True;Trust Server Certificate=True";
        }

    }
}

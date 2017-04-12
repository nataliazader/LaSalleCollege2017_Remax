using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormWebApp_Remax_Zader.DATASOURCE
{
    public static class Remax
    {
        public static SqlConnection getConnection()
        {
            var connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\LaSalleCollege2017_Remax\\WinFormWebApp_Remax_Zader\\WinFormWebApp_Remax_Zader\\App_Data\\Remax.mdf; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

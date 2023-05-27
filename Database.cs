using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Auto
{
    internal class Database
    {

        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=C41411\SQLEXPRESS;Initial Catalog=Auto;Integrated Security=True");
        public void openConnection()
        {
            if(sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }
        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

    }
}

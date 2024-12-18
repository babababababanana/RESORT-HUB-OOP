using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using MySql.Data.MySqlClient;

namespace resorthub
{
    public class Database
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arlan\\Downloads\\resortdatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public void ConnectionString()
        {
          
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select Count(*) from info_Table where  ", sqlConnection);
        }
       
        



    }
}

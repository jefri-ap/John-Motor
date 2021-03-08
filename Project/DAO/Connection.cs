using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project.DAO
{
    class Connection
    {
        public SqlConnection GetConnection()
        {
            ////**** Ubah lokasi direktori sesuaikan dengan file database ProjectLocalDb.mdf (AttachDbFileName=D:\Koding\C#\Project\ProjectLocalDB.mdf) ****////
            
            return new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true ;AttachDbFileName=D:\Koding\C#\Project\ProjectLocalDB.mdf");
        }
        public void closeConnection(SqlConnection _connection)
        {
            _connection.Close();
        }
    }
}

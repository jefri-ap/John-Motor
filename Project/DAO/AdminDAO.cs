using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Project.DAO
{
    class AdminDAO
    {
        private Connection koneksi;
        private SqlConnection connect;
        private SqlCommand dbCommand;
        private SqlDataReader dbDataReader;
        private bool successed;
        public AdminDAO()
        {
            koneksi = new Connection();
        }

        public bool Successed { get => successed; set => successed = value; }

        public string getIdAdmin()
        {
            string id = "";
            string idFinal = "";
            connect = koneksi.GetConnection();
            dbCommand = connect.CreateCommand();
            dbCommand.CommandText = "SELECT MAX(ID) FROM Admin";
            try
            {
                connect.Open();
                dbDataReader = dbCommand.ExecuteReader();
                while (dbDataReader.Read())
                {
                    id = dbDataReader.GetValue(0).ToString();
                }
                if(id.CompareTo("") == 0)
                {
                    idFinal = "1";
                }
                else
                {
                    int temp = int.Parse(id.Substring(0)) + 1;
                    idFinal = temp.ToString();
                }
                connect.Close();
                return idFinal;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public List<Admin> getUserAdmin()
        {
            List<Admin> listUser;
            connect = koneksi.GetConnection();
            dbCommand = connect.CreateCommand();
            dbCommand.CommandText = "SELECT * FROM Admin";
            try
            {
                connect.Open();
                dbDataReader = dbCommand.ExecuteReader();
                listUser = new List<Admin>();
                while (dbDataReader.Read())
                {
                    Admin objUserAdmin = new Admin(dbDataReader[0].ToString(), dbDataReader[1].ToString(), dbDataReader[2].ToString(), dbDataReader[3].ToString(), dbDataReader[4].ToString());
                    listUser.Add(objUserAdmin);
                }
                connect.Close();
                return listUser;
            }
            catch (Exception)
            {
                MessageBox.Show("Database tidak terkoneksi\r\nKeluar?", "Peringatan!", MessageBoxButtons.OK);
                return null;
            }
        }
        public void resetPasswordAdmin(Admin _userAdmin)
        {
            connect = koneksi.GetConnection();
            string sqlCmd = "UPDATE Admin SET Password = NULL WHERE ID = '" + _userAdmin.IdAdmin + "'";
            try
            {
                connect.Open();
                dbCommand = new SqlCommand (sqlCmd, connect);
                int result = dbCommand.ExecuteNonQuery();
                Successed = true;
                connect.Close();
            }
            catch (SqlException)
            {
                Successed = false;
            }
        }
    }
}

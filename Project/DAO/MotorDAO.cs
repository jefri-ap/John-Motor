using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project.DAO
{
    class MotorDAO
    {
        private Connection koneksi;
        private SqlConnection dbConnection;
        private SqlCommand dbCommand;
        private SqlDataReader dbDataReader;
        private bool isSukses;

        public bool IsSukses { get => isSukses; set => isSukses = value; }

        public MotorDAO()
        {
            koneksi = new Connection();
        }

        public string getID_Motor()
        {
            string id = "";
            string idFinal = "";
            dbConnection = koneksi.GetConnection();
            dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = "SELECT MAX(ID) FROM DataMotor";
            try
            {
                dbConnection.Open();
                dbDataReader = dbCommand.ExecuteReader();
                while (dbDataReader.Read())
                {
                    id = dbDataReader.GetValue(0).ToString();
                }
                if (id.CompareTo("") == 0)
                {
                    idFinal = "1";
                }
                else
                {
                    int x = int.Parse(id.Substring(0)) + 1;
                    idFinal = x.ToString();
                }
                dbConnection.Close();
                return idFinal;
            }
            catch (SqlException)
            {
                return null;
            }
        }


        public List<Motor> retriveDataMotor()
        {
            List<Motor> listMotor;
            dbConnection = koneksi.GetConnection();
            dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = "SELECT ID, ID_Kendaraan, MerkKendaraan, TipeKendaraan, TahunKendaraan, PlatNomor, TanggalBeli, HargaBeli FROM DataMotor";
            try
            {
                dbConnection.Open();
                dbDataReader = dbCommand.ExecuteReader();
                listMotor = new List<Motor>();
                while (dbDataReader.Read())
                {
                    Motor objDataMotor = new Motor(dbDataReader[0].ToString(),
                                                   dbDataReader[1].ToString(),
                                                   dbDataReader[2].ToString(),
                                                   dbDataReader[3].ToString(),
                                                   dbDataReader[4].ToString(),
                                                   dbDataReader[5].ToString(),
                                                   dbDataReader[6].ToString(),
                                                   dbDataReader[7].ToString());
                    listMotor.Add(objDataMotor);
                }
                dbConnection.Close();
                return listMotor;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public void insertNewDataMotor(Motor _dataMotor)
        {
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "INSERT INTO DataMotor (ID, ID_Kendaraan, MerkKendaraan, TipeKendaraan, TahunKendaraan, PlatNomor, TanggalBeli, HargaBeli) VALUES ('"
                            + _dataMotor.IdNomor
                            + "','"
                            + _dataMotor.IdKendaraan
                            + "','"
                            + _dataMotor.MerkKendaraan
                            + "','"
                            + _dataMotor.TipeKendaraan
                            + "','"
                            + _dataMotor.TahunKendaraan
                            + "','"
                            + _dataMotor.PlatNomor
                            + "','"
                            + _dataMotor.TanggalBeli
                            + "','"
                            + _dataMotor.HargaBeli
                            + "')";
            // string sql = "INSERT INTO PENGGUNA(ID,IDAdmin,Nama,Password) VALUES('4','q','q','q')";
            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand(sqlCmd, dbConnection);
                int result = dbCommand.ExecuteNonQuery();
                IsSukses = true;
                dbConnection.Close();
            }
            catch (SqlException)
            {
                IsSukses = false;
            }
        }
        public void updateDataMotor(Motor _dataMotor)
        {
            dbConnection = koneksi.GetConnection();   
            string sqlCmd = "UPDATE DataMotor SET MerkKendaraan='"
                            + _dataMotor.MerkKendaraan
                            + "', TipeKendaraan='"
                            + _dataMotor.TipeKendaraan
                            + "', TahunKendaraan='"
                            + _dataMotor.TahunKendaraan
                            + "', PlatNomor='"
                            + _dataMotor.PlatNomor
                            + "', TanggalBeli='"
                            + _dataMotor.TanggalBeli
                            + "', HargaBeli='"
                            + _dataMotor.HargaBeli
                            + "' WHERE ID_Kendaraan='"
                            + _dataMotor.IdKendaraan
                            + "' ";
            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand(sqlCmd, dbConnection);
                int result = dbCommand.ExecuteNonQuery();
                IsSukses = true;
                dbConnection.Close();
            }
            catch (SqlException)
            {
                IsSukses = false;
            }
        }

        public void deleteDataMotor(Motor _dataMotor)
        {
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "DELETE FROM DataMotor WHERE ID_Kendaraan= '" + _dataMotor.IdKendaraan + "' ";
            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand(sqlCmd, dbConnection);
                int result = dbCommand.ExecuteNonQuery();
                IsSukses = true;
                dbConnection.Close();
            }
            catch (SqlException)
            {
                IsSukses = false;
            }
        }

        public DataTable retriveDataGridMotor()
        {
            DataTable tableData = new DataTable();
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "SELECT ID_Kendaraan AS 'ID Motor', MerkKendaraan AS 'Merk Motor', TipeKendaraan AS 'Tipe Motor', TahunKendaraan AS 'Tahun', " +
                            "PlatNomor AS 'Plat Nomor', TanggalBeli AS 'Tanngal Pembelian', FORMAT(HargaBeli, '##,##0') AS 'Harga Pembelian', Status FROM DataMotor";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(tableData);
                return tableData;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                koneksi.closeConnection(dbConnection);
            }
        }

        public DataTable searchDataMotor(Searching _search)
        {
            DataTable tableData = new DataTable();
            dbConnection = koneksi.GetConnection();
            string sqlCmd = $"SELECT ID_Kendaraan AS 'ID Motor', MerkKendaraan AS 'Merk Motor', TipeKendaraan AS 'Tipe Motor', TahunKendaraan AS 'Tahun', "
                            + $"PlatNomor AS 'Plat Nomor', TanggalBeli AS 'Tanngal Pembelian', FORMAT(HargaBeli, '##,##0') AS 'Harga Pembelian', Status FROM DataMotor "
                            + $"WHERE MerkKendaraan LIKE '%{_search.Keyword}%' OR TipeKendaraan LIKE '%{_search.Keyword}%' OR TahunKendaraan LIKE '%{_search.Keyword}%' "
                            + $"OR PlatNomor LIKE '%{_search.Keyword}%' OR TanggalBeli LIKE '%{_search.Keyword}%' OR HargaBeli LIKE '%{_search.Keyword}%' "
                            + $"OR Status LIKE '%{_search.Keyword}%' ";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(tableData);
                return tableData;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                koneksi.closeConnection(dbConnection);
            }
        }

        public DataSet orderByData(OrderBy _order)
        {
            DataSet dataSet = new DataSet();
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "SELECT FORMAT(SUM(HargaBeli), '##,##0'), DATENAME(M, TanggalBeli), datepart(YYYY, TanggalBeli) FROM DataMotor " +
                            "WHERE DATENAME(M, TanggalBeli) LIKE '" + _order.Bulan + "' AND DATEPART(YYYY, TanggalBeli) LIKE '" + _order.Tahun + "' " +
                            "GROUP BY  DATENAME(MONTH, TanggalBeli), DATEPART(YYYY, TanggalBeli)";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                koneksi.closeConnection(dbConnection);
            }
        }
    }
}

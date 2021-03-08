using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entity;
using System.Data.SqlClient;
using System.Data;

namespace Project.DAO
{
    class TransaksiDAO
    {
        private Connection koneksi;
        private SqlConnection dbConnection;
        private SqlCommand dbCommand;
        private SqlDataReader dbDataReader;
        private bool isSukses;

        public bool IsSukses { get => isSukses; set => isSukses = value; }

        public TransaksiDAO()
        {
            koneksi = new Connection();
        }

        public string getIDTransaksi()
        {
            string id = "";
            string idFinal = "";
            dbConnection = koneksi.GetConnection();
            dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = "SELECT MAX(ID) FROM Transaksi";
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


        public List<Transaksi> retriveDataTransaksi()
        {
            List<Transaksi> listTransaksi;
            dbConnection = koneksi.GetConnection();
            dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = "SELECT ID, IDTrans, Nama, NomorHP, Alamat, TanggalJual, HargaJual FROM Transaksi";
            try
            {
                dbConnection.Open();
                dbDataReader = dbCommand.ExecuteReader();
                listTransaksi = new List<Transaksi>();
                while (dbDataReader.Read())
                {
                   Transaksi objDataTransaksi = new Transaksi(dbDataReader[0].ToString(),
                                                              dbDataReader[1].ToString(),
                                                              dbDataReader[2].ToString(),
                                                              dbDataReader[3].ToString(),
                                                              dbDataReader[4].ToString(),
                                                              dbDataReader[5].ToString(),
                                                              dbDataReader[6].ToString(),
                                                              dbDataReader[7].ToString());
                    listTransaksi.Add(objDataTransaksi);
                }
                dbConnection.Close();
                return listTransaksi;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void insertNewDataTransaksi(Transaksi _transaksi)
        {
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "INSERT INTO Transaksi (ID, IDTrans, IDMotor, Nama, NomorHP, Alamat, TanggalJual, HargaJual) VALUES ('"
                            + _transaksi.IDNomor
                            + "','"
                            + _transaksi.IDTrans
                            + "','"
                            + _transaksi.ID_Kendaraan
                            + "','"
                            + _transaksi.Nama
                            + "','"
                            + _transaksi.NomorHP
                            + "','"
                            + _transaksi.Alamat
                            + "','"
                            + _transaksi.TanggalJual
                            + "','"
                            + _transaksi.HargaJual
                            + "')";
            // string sql = "INSERT INTO NamaTable(Field1, Field2, Field3, Field4) VALUES('1','2','3','3')";
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
        public void updateDataTransaksi(Transaksi _transaksi)
        {
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "UPDATE Transaksi SET Nama='"
                            + _transaksi.Nama
                            + "', NomorHP='"
                            + _transaksi.NomorHP
                            + "', Alamat='"
                            + _transaksi.Alamat
                            + "', TanggalJual='"
                            + _transaksi.TanggalJual
                            + "', HargaJual='"
                            + _transaksi.HargaJual
                            + "' WHERE IDTrans= '"
                            + _transaksi.IDTrans
                            + "'";
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

        public void deleteTransaksi(Transaksi _transaksi)
        {
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "DELETE FROM Transaksi WHERE IDTrans= '" + _transaksi.IDTrans + "'";
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

        public DataTable retriveDataGridTransaksi()
        {
            DataTable tableData = new DataTable();
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "SELECT IDTrans AS 'ID Transaksi', Nama, NomorHP AS 'Nomor HP', Alamat, TanggalJual AS 'Tanggal Jual', FORMAT(HargaJual, '##,##0') AS 'Harga Jual', DataMotor.MerkKendaraan AS 'Merk Motor', DataMotor.TipeKendaraan AS 'Tipe Motor' FROM Transaksi INNER JOIN DataMotor ON IDMotor=ID_Kendaraan";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(tableData);
                return tableData;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                koneksi.closeConnection(dbConnection);
            }
        }

        public DataTable searchDataTransaksi(Searching _search)
        {
            DataTable tableData = new DataTable();
            dbConnection = koneksi.GetConnection();
            string sqlCmd = "SELECT IDTrans AS 'ID Transaksi', Nama, NomorHP AS 'Nomor HP', Alamat, TanggalJual AS 'Tanggal Jual', FORMAT(HargaJual, '##,##0') AS 'Harga Jual', DataMotor.MerkKendaraan AS 'Merk Motor', DataMotor.TipeKendaraan AS 'Tipe Motor' FROM Transaksi INNER JOIN DataMotor ON IDMotor=ID_Kendaraan WHERE "
                            + "Nama LIKE '%"
                            + _search.Keyword
                            + "%' OR Alamat LIKE '%"
                            + _search.Keyword
                            + "%' OR TanggalJual LIKE '%"
                            + _search.Keyword
                            + "%' OR HargaJual LIKE '%"
                            + _search.Keyword
                            + "%' OR DataMotor.MerkKendaraan LIKE '%"
                            + _search.Keyword
                            + "%' OR DataMotor.TipeKendaraan LIKE '%"
                            + _search.Keyword
                            + "%' ";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(tableData);
                return tableData;
            }
            catch (SqlException)
            {
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
            string sqlCmd = "SELECT FORMAT(SUM(HargaJual), '##,##0'), DATENAME(M, TanggalJual), datepart(YYYY, TanggalJual) FROM Transaksi " +
                            "WHERE DATENAME(M, TanggalJual) LIKE '" + _order.Bulan + "' AND DATEPART(YYYY, TanggalJual) LIKE '" + _order.Tahun + "' " +
                            "GROUP BY  DATENAME(MONTH, TanggalJual), DATEPART(YYYY, TanggalJual)";
            try
            {
                dbConnection.Open();
                SqlDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCmd, dbConnection);
                dbDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                koneksi.closeConnection(dbConnection);
            }
        }
    }
}

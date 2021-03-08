using Project.DAO;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Project.Manager
{
    class TransaksiManager
    {
        private TransaksiDAO transaksiData;
        public TransaksiManager()
        {
            transaksiData = new TransaksiDAO();
        }
        public List<Transaksi> getDataTransaksi()
        {
            return transaksiData.retriveDataTransaksi();
        }


        public string getIDNomor_transaksi()
        {
            return transaksiData.getIDTransaksi();
        }

        public void addNewDataTransaksi(Transaksi _transaksi)
        {
            transaksiData.insertNewDataTransaksi(_transaksi);
        }

        public bool successed()
        {
            return transaksiData.IsSukses;
        }

        public DataTable getRefreshDataTransaksi()
        {
            return transaksiData.retriveDataGridTransaksi();
        }

        public void editDataTransaksi(Transaksi _transaksi)
        {
            transaksiData.updateDataTransaksi(_transaksi);
        }
        public void hapusDataTransaksi(Transaksi _transaksi)
        {
            transaksiData.deleteTransaksi(_transaksi);
        }
        public DataTable cariDataTransaksi(Searching _search)
        {
            return transaksiData.searchDataTransaksi(_search);
        }

        public DataSet orderData(OrderBy order)
        {
            return transaksiData.orderByData(order);
        }
    }
}

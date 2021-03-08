using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Transaksi
    {
        private string iDNomor, iDTrans, iD_Kendaraan, nama, nomorHP, alamat, hargaJual, tanggalJual;

        public Transaksi() { }

        public Transaksi(string _idNomor, string _idTrans, string _idKendaraan, string _nama, string _nomorHP, string _alamat, string _tanggalJual, string _hargaJual)
        {
            IDNomor = _idNomor;
            IDTrans = _idTrans;
            ID_Kendaraan = _idKendaraan;
            Nama = _nama;
            NomorHP = _nomorHP;
            Alamat = _alamat;
            TanggalJual = _tanggalJual;
            HargaJual = _hargaJual;
        }

        public string IDNomor { get => iDNomor; set => iDNomor = value; }
        public string IDTrans { get => iDTrans; set => iDTrans = value; }
        public string ID_Kendaraan { get => iD_Kendaraan; set => iD_Kendaraan = value; }
        public string Nama { get => nama; set => nama = value; }
        public string NomorHP { get => nomorHP; set => nomorHP = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string TanggalJual { get => tanggalJual; set => tanggalJual = value; }
        public string HargaJual { get => hargaJual; set => hargaJual = value; }
    }
}

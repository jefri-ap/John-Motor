using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Motor
    {
        private string idNomor, idKendaraan, merkKendaraan, tahunKendaraan, tipeKendaraan, platNomor, tanggalBeli, hargaBeli;
        public Motor() { }
        public Motor(string _idNomor, string _idKendaraan, string _merkKendaraan, string _tipeKendaraan, string _tahunKendaraan, string _platNomor, string _tanggalBeli, string _hargaBeli)
        {
            IdNomor = _idNomor;
            IdKendaraan = _idKendaraan;
            MerkKendaraan = _merkKendaraan;
            TipeKendaraan = _tipeKendaraan;
            TahunKendaraan = _tahunKendaraan;
            PlatNomor = _platNomor;
            TanggalBeli = _tanggalBeli;
            HargaBeli = _hargaBeli;
        }


        public string IdNomor { get => idNomor; set => idNomor = value; }
        public string IdKendaraan { get => idKendaraan; set => idKendaraan = value; }
        public string MerkKendaraan { get => merkKendaraan; set => merkKendaraan = value; }
        public string TipeKendaraan { get => tipeKendaraan; set => tipeKendaraan = value; }
        public string TahunKendaraan { get => tahunKendaraan; set => tahunKendaraan = value; }
        public string PlatNomor { get => platNomor; set => platNomor = value; }
        public string TanggalBeli { get => tanggalBeli; set => tanggalBeli = value; }
        public string HargaBeli { get => hargaBeli; set => hargaBeli = value; }
    }
}

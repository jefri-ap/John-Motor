using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class OrderBy
    {
        private string bulan, tahun;

        public OrderBy() { }

        public OrderBy(string _bulan, string _tahun)
        {
            Bulan = _bulan;
            Tahun = _tahun;
        }

        public string Bulan { get => bulan; set => bulan = value; }
        public string Tahun { get => tahun; set => tahun = value; }
    }
}

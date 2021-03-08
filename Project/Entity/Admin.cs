using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    class Admin
    {
        private string idNomor, idAdmin, userName, password, nama;
        
        public Admin(){}
        public Admin(string _idNomor, string _idAdmin, string _userName, string _password, string _nama)
        {
            IdNomor = _idNomor;
            IdAdmin = _idAdmin;
            UserName = _userName;
            Password = _password;
            Nama = _nama;
        }

        public string IdNomor { get => idNomor; set => idNomor = value; }
        public string IdAdmin { get => idAdmin; set => idAdmin = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;
using Project.Entity;
using System.Data;

namespace Project.Manager
{
    class AdminManager
    {
        private AdminDAO userData;
        public AdminManager()
        {
            userData = new AdminDAO();
        }
        public List<Admin> getDataAdmin()
        {
            return userData.getUserAdmin();
        }
        public bool toVerifyAdmin(Admin _admin)
        {
            bool check = false;
            
            foreach(Admin objectTemp in getDataAdmin())
            {
                if(_admin.UserName.CompareTo(objectTemp.UserName) == 0 && _admin.Password.CompareTo(objectTemp.Password) == 0)
                {
                    check = true;
                }
            }
            return check;
        }
        public string getID_Admin()
        {
            return userData.getIdAdmin();
        }
        public bool successed()
        {
            return userData.Successed;
        }
        public void changePasswordAdmin(Admin _admin)
        {
            userData.resetPasswordAdmin(_admin);
        }
    }
}

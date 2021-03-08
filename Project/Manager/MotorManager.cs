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
    class MotorManager
    {
        private MotorDAO motorDAO;
        public MotorManager()
        {
            motorDAO = new MotorDAO();
        }
        public List<Motor> getDataMotor()
        {
            return motorDAO.retriveDataMotor();
        }


        public string getIDNomor_Motor()
        {
            return motorDAO.getID_Motor();
        }

        public void addNewDataMotor(Motor _motor)
        {
            motorDAO.insertNewDataMotor(_motor);
        }

        public bool successed()
        {
            return motorDAO.IsSukses;
        }

        public DataTable getRefreshDataMotor()
        {
            return motorDAO.retriveDataGridMotor();
        }

        public void editDataMotor(Motor _motor)
        {
            motorDAO.updateDataMotor(_motor);
        }
        public void hapusDataMotor(Motor _motor)
        {
            motorDAO.deleteDataMotor(_motor);
        }
        public DataTable cariDataMotor(Searching _search)
        {
            return motorDAO.searchDataMotor(_search);
        }

        public DataSet orderData(OrderBy order)
        {
            return motorDAO.orderByData(order);
        }
    }
}

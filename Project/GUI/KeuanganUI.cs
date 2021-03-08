using Project.Entity;
using Project.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    public partial class KeuanganUI : Form
    {
        OrderBy order;
        MotorManager managerMotor;
        TransaksiManager managerTransaksi;
        public KeuanganUI()
        {
            InitializeComponent();
            order = new OrderBy();
            managerMotor = new MotorManager();
            managerTransaksi = new TransaksiManager();

            monthBox.Text = "Bulan";
            monthBox.ForeColor = Color.Silver;
        }

        private void pilihBtnBeli_Click(object sender, EventArgs e)
        {
            OrderBy orderBy = new OrderBy(monthBox.Text, yearBox.Text);
            DataSet dataSet = new DataSet();

            monthBox.Text = "Bulan";
            monthBox.ForeColor = Color.Silver;
            yearBox.Text = "Tahun";
            yearBox.ForeColor = Color.Silver;
            try
            {
                dataSet.Clear();
                dataSet = managerMotor.orderData(orderBy);
                blnLabel.Text = dataSet.Tables[0].Rows[0][1].ToString() + " " + dataSet.Tables[0].Rows[0][2].ToString();
                sumLabel.Text = dataSet.Tables[0].Rows[0][0].ToString();

                if (blnLabel.Text == null || sumLabel.Text == null)
                {
                    blnLabel.Text = "Bulan";
                    sumLabel.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data tidak ada", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pilihBtnJual_Click(object sender, EventArgs e)
        {
            OrderBy orderBy = new OrderBy(monthBox2.Text, yearBox2.Text);
            DataSet dataSet = new DataSet();

            monthBox2.Text = "Bulan";
            monthBox2.ForeColor = Color.Silver;
            yearBox2.Text = "Tahun";
            yearBox2.ForeColor = Color.Silver;
            try
            {
                dataSet.Clear();
                dataSet = managerTransaksi.orderData(orderBy);
                blnLabel2.Text = dataSet.Tables[0].Rows[0][1].ToString() + " "  + dataSet.Tables[0].Rows[0][2].ToString();
                sumLabel2.Text = dataSet.Tables[0].Rows[0][0].ToString();

                if (blnLabel.Text == null || sumLabel.Text == null)
                {
                    blnLabel.Text = "Bulan";
                    sumLabel.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data tidak ada", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void monthBox_Enter(object sender, EventArgs e)
        {
            if(monthBox.Text == "Bulan")
            {
                monthBox.ForeColor = Color.Black;
            }
        }

        private void monthBox_Leave(object sender, EventArgs e)
        {
            if (monthBox.Text == "" || monthBox.Text == "Bulan")
            {
                monthBox.Text = "Bulan";
                monthBox.ForeColor = Color.Silver;
            }
        }

        private void yearBox_Enter(object sender, EventArgs e)
        {
            if (yearBox.Text == "Tahun")
            {
                yearBox.ForeColor = Color.Black;
            }
        }

        private void yearBox_Leave(object sender, EventArgs e)
        {
            if (yearBox.Text == "" || yearBox.Text == "Tahun")
            {
                yearBox.Text = "Tahun";
                yearBox.ForeColor = Color.Silver;
            }
        }

        private void monthBox2_Enter(object sender, EventArgs e)
        {
            if (monthBox2.Text == "Bulan")
            {
                monthBox2.ForeColor = Color.Black;
            }
        }

        private void monthBox2_Leave(object sender, EventArgs e)
        {
            if (monthBox2.Text == "" || monthBox2.Text == "Bulan")
            {
                monthBox2.Text = "Bulan";
                monthBox2.ForeColor = Color.Silver;
            }
        }

        private void yearBox2_Enter(object sender, EventArgs e)
        {
            if (yearBox2.Text == "Tahun")
            {
                yearBox2.ForeColor = Color.Black;
            }
        }

        private void yearBox2_Leave(object sender, EventArgs e)
        {
            if (yearBox2.Text == "" || yearBox2.Text == "Tahun")
            {
                yearBox2.Text = "Tahun";
                yearBox2.ForeColor = Color.Silver;
            }
        }
    }
}

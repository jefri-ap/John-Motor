using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Project.GUI;
using Project.Entity;
using Project.DAO;
using Project.Manager;
using System.Data;

namespace Project.GUI
{
    public partial class TransaksiADD : Form
    {
        TransaksiManager transaksiManager;
        Transaksi transaksiData;
        public TransaksiADD()
        {
            transaksiManager = new TransaksiManager();
            InitializeComponent();
            getID();
        }
        private void getID()
        {
            label_IDNomor.Text = transaksiManager.getIDNomor_transaksi();

            if (label_IDNomor.Text.ToString().Length == 1)
            {
                label_IDTrans.Text = "Trs00" + label_IDNomor.Text;
            }
            else if (label_IDNomor.Text.ToString().Length <= 2)
            {
                label_IDTrans.Text = "Trs" + label_IDNomor.Text;
            }

        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            (this.Owner as Motorcycle).panelButton.Enabled = true;
            (this.Owner as Motorcycle).panelSide.Hide();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            (this.Owner as Motorcycle).panelButton.Enabled = true;
            (this.Owner as Motorcycle).panelSide.Hide();
            this.Close();
        }

        private void miniMizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button_Simpan_Click(object sender, EventArgs e)
        {
            transaksiData = new Transaksi(label_IDNomor.Text,
                                          label_IDTrans.Text,
                                          label_IDMotor.Text,
                                          nama_TextBox.Text,
                                          nomorHp_TextBox.Text,
                                          alamat_TextBox.Text,
                                          tanggalJual_datePicker.Value.ToString("MM/dd/yyyy"),
                                          hargaJual_TextBox.Text.Replace(@".", "").Replace(@",", ""));

            if (nama_TextBox.Text.CompareTo("") == 0 || nomorHp_TextBox.Text.Trim().CompareTo("") == 0 || alamat_TextBox.Text.CompareTo("") == 0 || tanggalJual_datePicker.Text.Trim().CompareTo("") == 0 || hargaJual_TextBox.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Input tidak boleh kosong !", "Peringatan", MessageBoxButtons.OK);
            }
            else
            {
                transaksiManager.addNewDataTransaksi(transaksiData);
                TransaksiUI transaksiUI = new TransaksiUI();

                if (transaksiManager.successed() == true)
                {
                    transaksiUI.refreshDataGrid();
                    nama_TextBox.Text = "";
                    nomorHp_TextBox.Text = "";
                    alamat_TextBox.Text = "";
                    tanggalJual_datePicker.Text = "";
                    hargaJual_TextBox.Text = "";
                    label_IDNomor.Text = "-";
                    label_IDTrans.Text = "-";
                    label_IDMotor.Text = "-";

                    MessageBox.Show("Data Pengguna berhasil disimpan !", "Informasi", MessageBoxButtons.OK);
                    (this.Owner as Motorcycle).refreshDataGrid();
                    (this.Owner as Motorcycle).panelButton.Enabled = true;
                    (this.Owner as Motorcycle).panelSide.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Pengguna gagal disimpan !", "Pesan Kesalahan", MessageBoxButtons.OK);
                }
            }
        }
    }
}
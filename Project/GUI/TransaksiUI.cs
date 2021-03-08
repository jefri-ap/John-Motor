using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Manager;
using Project.Entity;

namespace Project.GUI
{
    public partial class TransaksiUI : Form
    {
        TransaksiManager transaksiManager;
        Transaksi transaksiData;
        int pilih;
        string select, select1, select2, select3, select4, select5;

        public TransaksiUI()
        {
            transaksiManager = new TransaksiManager();
            InitializeComponent();
            panelSide.Hide();
            panelButton.Enabled = true;
            panelInput.Enabled = false;
            refreshDataGrid();
        }

        private void cari_TextBox_TextChanged(object sender, EventArgs e)
        {
            Searching cari = new Searching(cari_TextBox.Text.Replace(@".", "").Replace(@",", ""));
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Clear();
                dataTable = transaksiManager.cariDataTransaksi(cari);
                trans_dataGridView.DataSource = dataTable;
            }
            catch (System.Data.SqlClient.SqlException e1)
            {
                MessageBox.Show("Terjadi kesalahan pada Koneksi database" + e1.Message.ToString().Trim(), "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e2)
            {
                MessageBox.Show("Terjadi kesalahan pada Koneksi database" + e2.Message.ToString().Trim(), "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cari_TextBox_Enter(object sender, EventArgs e)
        {
            searchIcon.Hide();
        }

        private void cari_TextBox_Leave(object sender, EventArgs e)
        {
            searchIcon.Show();
            cari_TextBox.Text = "";
        }

        public void refreshDataGrid()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Clear();
                dataTable = transaksiManager.getRefreshDataTransaksi();
                trans_dataGridView.DataSource = dataTable;
            }
            catch (System.Data.SqlClient.SqlException e1)
            {
                MessageBox.Show("Terjadi kesalahan pada Koneksi database" + e1.Message.ToString().Trim(), "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e2)
            {
                MessageBox.Show("Terjadi kesalahan pada Koneksi database" + e2.Message.ToString().Trim(), "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            pilih = 1;
            panelSide.Show();
            panelSide.Height = editBtn.Height;
            panelSide.Top = editBtn.Top;

            panelButton.Enabled = false;
            panelInput.Enabled = true;

            try
            {
                if (Convert.IsDBNull(trans_dataGridView) == true)
                {
                    MessageBox.Show("Data Masih Kosong!!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    int row_index = trans_dataGridView.CurrentCell.RowIndex;
                    select = trans_dataGridView.Rows[row_index].Cells[0].Value.ToString();
                    select1 = trans_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                    select2 = trans_dataGridView.Rows[row_index].Cells[2].Value.ToString();
                    select3 = trans_dataGridView.Rows[row_index].Cells[3].Value.ToString();
                    select4 = trans_dataGridView.Rows[row_index].Cells[4].Value.ToString();
                    select5 = trans_dataGridView.Rows[row_index].Cells[5].Value.ToString();

                    label_IDTrans.Text = select;
                    nama_TextBox.Text = select1;
                    nomorHP_TextBox.Text = select2;
                    alamat_TextBox.Text = select3;
                    tanggalJual_datePicker.Text = select4;
                    hargaJual_TextBox.Text = select5;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data Masih Kosong!!", "Warning", MessageBoxButtons.OK);
            }
            infoLabel.Text = "Edit Data?";
            cari_TextBox.Enabled = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            pilih = 2;
            panelSide.Show();
            panelSide.Height = deleteBtn.Height;
            panelSide.Top = deleteBtn.Top;

            panelButton.Enabled = false;
            panelInput.Enabled = true;
            int row_index = trans_dataGridView.CurrentCell.RowIndex;
            select = trans_dataGridView.Rows[row_index].Cells[0].Value.ToString();
            select1 = trans_dataGridView.Rows[row_index].Cells[1].Value.ToString();
            select2 = trans_dataGridView.Rows[row_index].Cells[2].Value.ToString();
            select3 = trans_dataGridView.Rows[row_index].Cells[3].Value.ToString();
            select4 = trans_dataGridView.Rows[row_index].Cells[4].Value.ToString();
            select5 = trans_dataGridView.Rows[row_index].Cells[5].Value.ToString();

            label_IDTrans.Text = select;
            nama_TextBox.Text = select1;
            nomorHP_TextBox.Text = select2;
            alamat_TextBox.Text = select3;
            tanggalJual_datePicker.Text = select4;
            hargaJual_TextBox.Text = select5;

            nama_TextBox.Enabled = false;
            nomorHP_TextBox.Enabled = false;
            alamat_TextBox.Enabled = false;
            tanggalJual_datePicker.Enabled = false;
            hargaJual_TextBox.Enabled = false;
            infoLabel.Text = "Hapus Data?";
            button_Simpan.Text = "Hapus";
            cari_TextBox.Enabled = false;
        }

        private void button_Simpan_Click(object sender, EventArgs e)
        {
            if (pilih == 1)
            {
                transaksiData = new Transaksi("",
                                              label_IDTrans.Text,
                                              "",
                                              nama_TextBox.Text,
                                              nomorHP_TextBox.Text,
                                              alamat_TextBox.Text,
                                              tanggalJual_datePicker.Value.ToString("MM/dd/yyyy"),
                                              hargaJual_TextBox.Text.Replace(@".", "").Replace(@",", ""));
                if (nama_TextBox.Text.CompareTo("") == 0 || nomorHP_TextBox.Text.Trim().CompareTo("") == 0 || alamat_TextBox.Text.CompareTo("") == 0 || tanggalJual_datePicker.Text.Trim().CompareTo("") == 0 || hargaJual_TextBox.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Input tidak boleh kosong !", "Peringatan", MessageBoxButtons.OK);
                }
                else
                {
                    transaksiManager.editDataTransaksi(transaksiData);
                    if (transaksiManager.successed() == true)
                    {
                        refreshDataGrid(); 
                        nama_TextBox.Text = "";
                        nomorHP_TextBox.Text = "";
                        alamat_TextBox.Text = "";
                        tanggalJual_datePicker.Text = "";
                        hargaJual_TextBox.Text = "";
                        label_IDTrans.Text = "-";
                        panelInput.Enabled = false;
                        panelButton.Enabled = true;

                        MessageBox.Show("Data Pengguna berhasil diubah!", "Informasi", MessageBoxButtons.OK);
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data Pengguna gagal diubah!", "Pesan Kesalahan", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (pilih == 2)
                {

                    transaksiData = new Transaksi("",
                                                  label_IDTrans.Text,
                                                  "",
                                                  "",
                                                  "",
                                                  "",
                                                  "",
                                                  "");

                    transaksiManager.hapusDataTransaksi(transaksiData);
                    if (transaksiManager.successed() == true)
                    {
                        refreshDataGrid();
                        nama_TextBox.Text = "";
                        nomorHP_TextBox.Text = "";
                        alamat_TextBox.Text = "";
                        tanggalJual_datePicker.Text = "";
                        hargaJual_TextBox.Text = "";
                        label_IDTrans.Text = "-";
                        panelInput.Enabled = false;
                        panelButton.Enabled = true;

                        MessageBox.Show("Data Pengguna berhasil dihapus!", "Informasi", MessageBoxButtons.OK);
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data Pengguna gagal dihapus!", "Pesan Kesalahan", MessageBoxButtons.OK);
                    }
                    refreshDataGrid();

                    nama_TextBox.Enabled = true;
                    nomorHP_TextBox.Enabled = true;
                    alamat_TextBox.Enabled = true;
                    tanggalJual_datePicker.Enabled = true;
                    hargaJual_TextBox.Enabled = true;
                    cari_TextBox.Enabled = true;
                }
            }
        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            nama_TextBox.Text = "";
            nomorHP_TextBox.Text = "";
            alamat_TextBox.Text = "";
            tanggalJual_datePicker.Text = "";
            hargaJual_TextBox.Text = "";
            label_IDTrans.Text = "-";
            panelInput.Enabled = false;
            panelButton.Enabled = true;

            nama_TextBox.Enabled = true;
            nomorHP_TextBox.Enabled = true;
            alamat_TextBox.Enabled = true;
            tanggalJual_datePicker.Enabled = true;
            hargaJual_TextBox.Enabled = true;
            cari_TextBox.Enabled = true;

            infoLabel.Text = "";
            panelSide.Hide();
        }
    }
}

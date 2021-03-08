using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.GUI;
using Project.Entity;
using Project.DAO;
using Project.Manager;

namespace Project.GUI
{
    public partial class Motorcycle : Form
    {
        MotorManager manager;
        Motor motorData;
        int pilih;
        string select, select1, select2, select3, select4, select5, select6;

        public Motorcycle()
        {
            manager = new MotorManager();
            InitializeComponent();
            panelSide.Hide();
            panelButton.Enabled = true;
            panelInput.Enabled = false;
            refreshDataGrid();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Searching cari = new Searching(searchTextBox.Text.Replace(@".", "").Replace(@",", ""));
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Clear();
                dataTable = manager.cariDataMotor(cari);
                dataGridViewMotor.DataSource = dataTable;
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

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchIcon.Hide();
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            searchIcon.Show();
            searchTextBox.Text = "";
        }

        public void refreshDataGrid()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Clear();
                dataTable = manager.getRefreshDataMotor();
                dataGridViewMotor.DataSource = dataTable;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            pilih = 1;
            panelSide.Show();
            panelSide.Height = addBtn.Height;
            panelSide.Top = addBtn.Top;

            panelButton.Enabled = false;
            panelInput.Enabled = true;
            searchTextBox.Enabled = false;
            searchIcon.BackColor = Color.Cyan;
            searchIcon.IconColor = Color.White;

            if (manager.getIDNomor_Motor().ToString().Length == 1)
            {
                label_IDMotor.Text = "Mtr0" + manager.getIDNomor_Motor();
            }
            else if (manager.getIDNomor_Motor().ToString().Length == 2)
            {
                label_IDMotor.Text = "Mtr" + manager.getIDNomor_Motor();
            }
            infoLabel.Text = "Tambah Data?";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            pilih = 2;
            panelSide.Show();
            panelSide.Height = editBtn.Height;
            panelSide.Top = editBtn.Top;

            panelButton.Enabled = false;
            panelInput.Enabled = true;
            searchTextBox.Enabled = false;
            searchIcon.BackColor = Color.Cyan;
            searchIcon.IconColor = Color.White;

            try
            {
                int row_index = dataGridViewMotor.CurrentCell.RowIndex;
                select = dataGridViewMotor.Rows[row_index].Cells[0].Value.ToString();
                select1 = dataGridViewMotor.Rows[row_index].Cells[1].Value.ToString();
                select2 = dataGridViewMotor.Rows[row_index].Cells[2].Value.ToString();
                select3 = dataGridViewMotor.Rows[row_index].Cells[3].Value.ToString();
                select4 = dataGridViewMotor.Rows[row_index].Cells[4].Value.ToString();
                select5 = dataGridViewMotor.Rows[row_index].Cells[5].Value.ToString();
                select6 = dataGridViewMotor.Rows[row_index].Cells[6].Value.ToString();
                label_IDMotor.Text = select;
                textBox_InputMerk.Text = select1;
                textBox_InputTipe.Text = select2;
                textBox_InputTahun.Text = select3;
                textBox_InputPlatNomor.Text = select4;
                dateTanggalBeli.Text = select5;
                textBox_InputHargaBeli.Text = select6;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Data Masih Kosong!!", "Warning", MessageBoxButtons.OK);
            }
            infoLabel.Text = "Edit Data?";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            pilih = 3;
            panelSide.Show();
            panelSide.Height = deleteBtn.Height;
            panelSide.Top = deleteBtn.Top;

            panelButton.Enabled = false;
            panelInput.Enabled = true;
            searchTextBox.Enabled = false;
            searchIcon.BackColor = Color.Cyan;
            searchIcon.IconColor = Color.White;

            int row_index = dataGridViewMotor.CurrentCell.RowIndex;
            select = dataGridViewMotor.Rows[row_index].Cells[0].Value.ToString();
            select1 = dataGridViewMotor.Rows[row_index].Cells[1].Value.ToString();
            select2 = dataGridViewMotor.Rows[row_index].Cells[2].Value.ToString();
            select3 = dataGridViewMotor.Rows[row_index].Cells[3].Value.ToString();
            select4 = dataGridViewMotor.Rows[row_index].Cells[4].Value.ToString();
            select5 = dataGridViewMotor.Rows[row_index].Cells[5].Value.ToString();
            select6 = dataGridViewMotor.Rows[row_index].Cells[6].Value.ToString();
            label_IDMotor.Text = select;
            textBox_InputMerk.Text = select1;
            textBox_InputTipe.Text = select2;
            textBox_InputTahun.Text = select3;
            textBox_InputPlatNomor.Text = select4;
            dateTanggalBeli.Text = select5;
            textBox_InputHargaBeli.Text = select6;

            textBox_InputMerk.Enabled = false;
            textBox_InputTipe.Enabled = false;
            textBox_InputTahun.Enabled = false;
            textBox_InputPlatNomor.Enabled = false;
            dateTanggalBeli.Enabled = false;
            textBox_InputHargaBeli.Enabled = false;
            infoLabel.Text = "Hapus Data?";
            button_Simpan.Text = "Hapus";

            if (searchTextBox.Text == "          Cari Data")
            {
                Searching cari = new Searching("");
            }
        }

        private void soldBtn_Click(object sender, EventArgs e)
        {
            panelSide.Show();
            panelSide.Height = soldBtn.Height;
            panelSide.Top = soldBtn.Top;
            searchIcon.BackColor = Color.Cyan;
            searchIcon.IconColor = Color.White;

            int row_index = dataGridViewMotor.CurrentCell.RowIndex;
            if (dataGridViewMotor.Rows[row_index].Cells[7].Value.ToString() == "Terjual")
            {
                MessageBox.Show("Motor sudah terjual!", "INFO", MessageBoxButtons.OK);
                panelSide.Hide();
            }
            else
            {
                TransaksiADD transaksiAdd = new TransaksiADD();
                transaksiAdd.Owner = this;
                panelButton.Enabled = false;

                transaksiAdd.label_IDMotor.Text = this.dataGridViewMotor.Rows[row_index].Cells[0].Value.ToString();
                transaksiAdd.Show();

            }
        }


        private void button_Simpan_Click(object sender, EventArgs e)
        {
            if (pilih == 1)
            {
                motorData = new Motor(manager.getIDNomor_Motor(),
                                      label_IDMotor.Text,
                                      textBox_InputMerk.Text,
                                      textBox_InputTipe.Text,
                                      textBox_InputTahun.Text,
                                      textBox_InputPlatNomor.Text,
                                      dateTanggalBeli.Value.ToString("MM/dd/yyyy"),
                                      textBox_InputHargaBeli.Text.Replace(@".", "").Replace(@",", ""));
                if (textBox_InputMerk.Text.CompareTo("") == 0 || textBox_InputTipe.Text.Trim().CompareTo("") == 0 || textBox_InputTahun.Text.CompareTo("") == 0 || textBox_InputPlatNomor.Text.Trim().CompareTo("") == 0 || dateTanggalBeli.Text.CompareTo("") == 0 || textBox_InputHargaBeli.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Input tidak boleh kosong !", "Peringatan", MessageBoxButtons.OK);
                }
                else
                {
                    manager.addNewDataMotor(motorData);
                    if (manager.successed() == true)
                    {
                        refreshDataGrid();
                        textBox_InputMerk.Text = "";
                        textBox_InputTipe.Text = "";
                        textBox_InputTahun.Text = "";
                        textBox_InputPlatNomor.Text = "";
                        dateTanggalBeli.Text = "";
                        textBox_InputHargaBeli.Text = "";
                        label_IDMotor.Text = "-";
                        panelInput.Enabled = false;
                        panelButton.Enabled = true;

                        MessageBox.Show("Data Pengguna berhasil disimpan !", "Informasi", MessageBoxButtons.OK);
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data Pengguna gagal disimpan !", "Pesan Kesalahan", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (pilih == 2)
                {
                    motorData = new Motor("",
                                          label_IDMotor.Text,
                                          textBox_InputMerk.Text,
                                          textBox_InputTipe.Text,
                                          textBox_InputTahun.Text,
                                          textBox_InputPlatNomor.Text,
                                          dateTanggalBeli.Value.ToString("MM/dd/yyyy"),
                                          textBox_InputHargaBeli.Text.Replace(@".", "").Replace(@",", ""));
                    if (textBox_InputMerk.Text.CompareTo("") == 0 || textBox_InputTipe.Text.Trim().CompareTo("") == 0 || textBox_InputTahun.Text.CompareTo("") == 0 || textBox_InputPlatNomor.Text.Trim().CompareTo("") == 0 || dateTanggalBeli.Text.CompareTo("") == 0 || textBox_InputHargaBeli.Text.Trim().CompareTo("") == 0)
                    {
                        MessageBox.Show("Input tidak boleh kosong !", "Peringatan", MessageBoxButtons.OK);
                    }
                    else
                    {
                        manager.editDataMotor(motorData);
                        if (manager.successed() == true)
                        {
                            refreshDataGrid();
                            textBox_InputMerk.Text = "";
                            textBox_InputTipe.Text = "";
                            textBox_InputTahun.Text = "";
                            textBox_InputPlatNomor.Text = "";
                            dateTanggalBeli.Text = "";
                            textBox_InputHargaBeli.Text = "";
                            label_IDMotor.Text = "-";
                            panelInput.Enabled = false;
                            panelButton.Enabled = true;

                            MessageBox.Show("Data Pengguna berhasil diubah !", "Informasi", MessageBoxButtons.OK);
                            refreshDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Data Pengguna gagal diubah !", "Pesan Kesalahan", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    if (pilih == 3)
                    {

                        motorData = new Motor("", label_IDMotor.Text, "", "", "", "", "", "");

                        manager.hapusDataMotor(motorData);
                        if (manager.successed() == true)
                        {
                            refreshDataGrid();
                            textBox_InputMerk.Text = "";
                            textBox_InputTipe.Text = "";
                            textBox_InputTahun.Text = "";
                            textBox_InputPlatNomor.Text = "";
                            dateTanggalBeli.Text = "";
                            textBox_InputHargaBeli.Text = "";
                            label_IDMotor.Text = "-";
                            panelInput.Enabled = false;
                            panelButton.Enabled = true;

                            MessageBox.Show("Data Pengguna berhasil dihapus !", "Informasi", MessageBoxButtons.OK);
                            refreshDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Data Pengguna gagal dihapus !", "Pesan Kesalahan", MessageBoxButtons.OK);
                        }
                        refreshDataGrid();
                    }
                }
            }
            textBox_InputMerk.Enabled = true;
            textBox_InputTipe.Enabled = true;
            textBox_InputTahun.Enabled = true;
            textBox_InputPlatNomor.Enabled = true;
            dateTanggalBeli.Enabled = true;
            textBox_InputHargaBeli.Enabled = true;

            infoLabel.Text = "";
            button_Simpan.Text = "Simpan";
            panelSide.Hide();
            searchIcon.BackColor = Color.Transparent;
            searchIcon.IconColor = Color.Silver;
        }

        private void button_Batal_Click(object sender, EventArgs e)
        {
            textBox_InputMerk.Text = "";
            textBox_InputTipe.Text = "";
            textBox_InputTahun.Text = "";
            textBox_InputPlatNomor.Text = "";
            dateTanggalBeli.Text = "";
            textBox_InputHargaBeli.Text = "";
            label_IDMotor.Text = "-";

            panelInput.Enabled = false;
            panelButton.Enabled = true;
            searchTextBox.Enabled = true;

            textBox_InputMerk.Enabled = true;
            textBox_InputTipe.Enabled = true;
            textBox_InputTahun.Enabled = true;
            textBox_InputPlatNomor.Enabled = true;
            dateTanggalBeli.Enabled = true;
            textBox_InputHargaBeli.Enabled = true;

            button_Simpan.Text = "Simpan";
            infoLabel.Text = "";
            panelSide.Hide();
            searchIcon.BackColor = Color.Transparent;
            searchIcon.IconColor = Color.Silver;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project.DAO;
using Project.Entity;
using Project.Manager;

namespace Project.DAO
{
    public partial class Login : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        private AdminManager controller;

        public Login()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            controller = new AdminManager();
            passwordBox.UseSystemPasswordChar = true;
        }

        private void unameTextBox_Enter(object sender, EventArgs e)
        {
            if (unameTextBox.Text == "Username")
            {
                unameTextBox.Text = "";
                unameTextBox.ForeColor = Color.Black;
            }
        }

        private void unameTextBox_Leave(object sender, EventArgs e)
        {
            if (unameTextBox.Text == "")
            {
                unameTextBox.Text = "Username";
                unameTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
                passwordBox.ForeColor = Color.Black;
                passwordBox.UseSystemPasswordChar = false;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Password";
                passwordBox.ForeColor = Color.Silver;
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Admin objectLogin = new Admin("", "", unameTextBox.Text.Trim(), passwordBox.Text.Trim(), "");
            if (controller.toVerifyAdmin(objectLogin) == true)
            {
                MessageBox.Show("Berhasil Login!\r\n Selamat Datang " + objectLogin.Nama, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI.Dashboard menu = new GUI.Dashboard();
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Masukan Username dan Password", "Login Gagal", MessageBoxButtons.OK);
                unameTextBox.Text = "";
                passwordBox.Text = "";
            }
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                passwordBox.UseSystemPasswordChar = true;
            }
            else passwordBox.UseSystemPasswordChar = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miniMizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)//Button Login = Keyboard Enter
        {
            if (keyData == (Keys.Enter))
            {
                loginBtn.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

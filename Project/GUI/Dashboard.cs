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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

            titleLabel.Text = "HOME";
            Home formHome = new Home() { TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panelUtama.Controls.Add(formHome);
            formHome.Show();
            {

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keluar Aplikasi?", "Keluar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void miniMizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            panelUtama.Controls.Clear();
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

            titleLabel.Text = "HOME";
            Home formHome = new Home() { TopLevel = false, TopMost = true };
            formHome.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panelUtama.Controls.Add(formHome);
            formHome.Show();
        }

        private void mtrBtn_Click(object sender, EventArgs e)
        {
            panelUtama.Controls.Clear();
            sidePanel.Height = mtrBtn.Height;
            sidePanel.Top = mtrBtn.Top;

            titleLabel.Text = "MOTORCYCLE";
            Motorcycle formMotor = new Motorcycle() { TopLevel = false, TopMost = true };
            formMotor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panelUtama.Controls.Add(formMotor);
            formMotor.Show();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            panelUtama.Controls.Clear();
            sidePanel.Height = transBtn.Height;
            sidePanel.Top = transBtn.Top;

            titleLabel.Text = "TRANSACTION";
            TransaksiUI formTransaksiUI = new TransaksiUI() { TopLevel = false, TopMost = true };
            formTransaksiUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panelUtama.Controls.Add(formTransaksiUI);
            formTransaksiUI.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            panelUtama.Controls.Clear();
            sidePanel.Height = reportBtn.Height;
            sidePanel.Top = reportBtn.Top;

            titleLabel.Text = "REPORT";
            KeuanganUI keuangan = new KeuanganUI() { TopLevel = false, TopMost = true };
            keuangan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panelUtama.Controls.Add(keuangan);
            keuangan.Show();
        }
    }
}

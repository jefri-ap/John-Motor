namespace Project.GUI
{
    partial class KeuanganUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blnLabel2 = new System.Windows.Forms.Label();
            this.sumLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pilihBtnJual = new FontAwesome.Sharp.IconButton();
            this.yearBox2 = new System.Windows.Forms.ComboBox();
            this.monthBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blnLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pilihBtnBeli = new FontAwesome.Sharp.IconButton();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 562);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blnLabel2);
            this.groupBox2.Controls.Add(this.sumLabel2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pilihBtnJual);
            this.groupBox2.Controls.Add(this.yearBox2);
            this.groupBox2.Controls.Add(this.monthBox2);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Penjualan";
            // 
            // blnLabel2
            // 
            this.blnLabel2.AutoSize = true;
            this.blnLabel2.Location = new System.Drawing.Point(5, 84);
            this.blnLabel2.Name = "blnLabel2";
            this.blnLabel2.Size = new System.Drawing.Size(49, 19);
            this.blnLabel2.TabIndex = 8;
            this.blnLabel2.Text = "Bulan";
            // 
            // sumLabel2
            // 
            this.sumLabel2.AutoSize = true;
            this.sumLabel2.Location = new System.Drawing.Point(155, 116);
            this.sumLabel2.Name = "sumLabel2";
            this.sumLabel2.Size = new System.Drawing.Size(18, 19);
            this.sumLabel2.TabIndex = 9;
            this.sumLabel2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Penjualan: Rp.";
            // 
            // pilihBtnJual
            // 
            this.pilihBtnJual.BackColor = System.Drawing.Color.Blue;
            this.pilihBtnJual.FlatAppearance.BorderSize = 0;
            this.pilihBtnJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pilihBtnJual.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pilihBtnJual.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.pilihBtnJual.IconColor = System.Drawing.Color.Black;
            this.pilihBtnJual.IconSize = 20;
            this.pilihBtnJual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihBtnJual.Location = new System.Drawing.Point(323, 26);
            this.pilihBtnJual.Name = "pilihBtnJual";
            this.pilihBtnJual.Rotation = 0D;
            this.pilihBtnJual.Size = new System.Drawing.Size(79, 28);
            this.pilihBtnJual.TabIndex = 6;
            this.pilihBtnJual.Text = "Pilih";
            this.pilihBtnJual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pilihBtnJual.UseVisualStyleBackColor = false;
            this.pilihBtnJual.Click += new System.EventHandler(this.pilihBtnJual_Click);
            // 
            // yearBox2
            // 
            this.yearBox2.ForeColor = System.Drawing.Color.Silver;
            this.yearBox2.FormattingEnabled = true;
            this.yearBox2.Items.AddRange(new object[] {
            "Tahun",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.yearBox2.Location = new System.Drawing.Point(164, 26);
            this.yearBox2.Name = "yearBox2";
            this.yearBox2.Size = new System.Drawing.Size(152, 27);
            this.yearBox2.TabIndex = 5;
            this.yearBox2.Text = "Tahun";
            this.yearBox2.Enter += new System.EventHandler(this.yearBox2_Enter);
            this.yearBox2.Leave += new System.EventHandler(this.yearBox2_Leave);
            // 
            // monthBox2
            // 
            this.monthBox2.ForeColor = System.Drawing.Color.Silver;
            this.monthBox2.FormattingEnabled = true;
            this.monthBox2.Items.AddRange(new object[] {
            "Bulan",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox2.Location = new System.Drawing.Point(6, 27);
            this.monthBox2.Name = "monthBox2";
            this.monthBox2.Size = new System.Drawing.Size(152, 27);
            this.monthBox2.TabIndex = 4;
            this.monthBox2.Text = "Bulan";
            this.monthBox2.Enter += new System.EventHandler(this.monthBox2_Enter);
            this.monthBox2.Leave += new System.EventHandler(this.monthBox2_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blnLabel);
            this.groupBox1.Controls.Add(this.sumLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pilihBtnBeli);
            this.groupBox1.Controls.Add(this.yearBox);
            this.groupBox1.Controls.Add(this.monthBox);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembelian";
            // 
            // blnLabel
            // 
            this.blnLabel.AutoSize = true;
            this.blnLabel.Location = new System.Drawing.Point(6, 84);
            this.blnLabel.Name = "blnLabel";
            this.blnLabel.Size = new System.Drawing.Size(49, 19);
            this.blnLabel.TabIndex = 3;
            this.blnLabel.Text = "Bulan";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(160, 116);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(18, 19);
            this.sumLabel.TabIndex = 3;
            this.sumLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Pembelian: Rp.";
            // 
            // pilihBtnBeli
            // 
            this.pilihBtnBeli.BackColor = System.Drawing.Color.Blue;
            this.pilihBtnBeli.FlatAppearance.BorderSize = 0;
            this.pilihBtnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pilihBtnBeli.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pilihBtnBeli.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.pilihBtnBeli.IconColor = System.Drawing.Color.Black;
            this.pilihBtnBeli.IconSize = 20;
            this.pilihBtnBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihBtnBeli.Location = new System.Drawing.Point(324, 26);
            this.pilihBtnBeli.Name = "pilihBtnBeli";
            this.pilihBtnBeli.Rotation = 0D;
            this.pilihBtnBeli.Size = new System.Drawing.Size(79, 28);
            this.pilihBtnBeli.TabIndex = 3;
            this.pilihBtnBeli.Text = "Pilih";
            this.pilihBtnBeli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pilihBtnBeli.UseVisualStyleBackColor = false;
            this.pilihBtnBeli.Click += new System.EventHandler(this.pilihBtnBeli_Click);
            // 
            // yearBox
            // 
            this.yearBox.ForeColor = System.Drawing.Color.Silver;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "Tahun",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.yearBox.Location = new System.Drawing.Point(165, 26);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(152, 27);
            this.yearBox.TabIndex = 2;
            this.yearBox.Text = "Tahun";
            this.yearBox.Enter += new System.EventHandler(this.yearBox_Enter);
            this.yearBox.Leave += new System.EventHandler(this.yearBox_Leave);
            // 
            // monthBox
            // 
            this.monthBox.ForeColor = System.Drawing.Color.Silver;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "Bulan",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(7, 27);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(152, 27);
            this.monthBox.TabIndex = 1;
            this.monthBox.Text = "Bulan";
            this.monthBox.Enter += new System.EventHandler(this.monthBox_Enter);
            this.monthBox.Leave += new System.EventHandler(this.monthBox_Leave);
            // 
            // KeuanganUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeuanganUI";
            this.Text = "KeuanganUI";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label blnLabel2;
        private System.Windows.Forms.Label sumLabel2;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton pilihBtnJual;
        private System.Windows.Forms.ComboBox yearBox2;
        private System.Windows.Forms.ComboBox monthBox2;
        private System.Windows.Forms.Label blnLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton pilihBtnBeli;
        private System.Windows.Forms.ComboBox yearBox;
    }
}
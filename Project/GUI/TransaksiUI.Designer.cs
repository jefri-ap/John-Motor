namespace Project.GUI
{
    partial class TransaksiUI
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
            this.trans_dataGridView = new System.Windows.Forms.DataGridView();
            this.cari_TextBox = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nama_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomorHP_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alamat_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_IDTrans = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hargaJual_TextBox = new System.Windows.Forms.TextBox();
            this.button_Batal = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.tanggalJual_datePicker = new System.Windows.Forms.DateTimePicker();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trans_dataGridView)).BeginInit();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // trans_dataGridView
            // 
            this.trans_dataGridView.AllowUserToAddRows = false;
            this.trans_dataGridView.AllowUserToDeleteRows = false;
            this.trans_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.trans_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trans_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trans_dataGridView.Location = new System.Drawing.Point(12, 51);
            this.trans_dataGridView.Name = "trans_dataGridView";
            this.trans_dataGridView.ReadOnly = true;
            this.trans_dataGridView.Size = new System.Drawing.Size(806, 292);
            this.trans_dataGridView.TabIndex = 0;
            // 
            // cari_TextBox
            // 
            this.cari_TextBox.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_TextBox.Location = new System.Drawing.Point(12, 13);
            this.cari_TextBox.Multiline = true;
            this.cari_TextBox.Name = "cari_TextBox";
            this.cari_TextBox.Size = new System.Drawing.Size(806, 35);
            this.cari_TextBox.TabIndex = 11;
            this.cari_TextBox.TextChanged += new System.EventHandler(this.cari_TextBox_TextChanged);
            this.cari_TextBox.Enter += new System.EventHandler(this.cari_TextBox_Enter);
            this.cari_TextBox.Leave += new System.EventHandler(this.cari_TextBox_Leave);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Maroon;
            this.panelButton.Controls.Add(this.deleteBtn);
            this.panelButton.Controls.Add(this.editBtn);
            this.panelButton.Controls.Add(this.panelSide);
            this.panelButton.Location = new System.Drawing.Point(825, -3);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 565);
            this.panelButton.TabIndex = 13;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 118);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(197, 48);
            this.panelSide.TabIndex = 6;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.ForeColor = System.Drawing.Color.Silver;
            this.searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchIcon.IconColor = System.Drawing.Color.Silver;
            this.searchIcon.IconSize = 30;
            this.searchIcon.Location = new System.Drawing.Point(14, 15);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 30);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchIcon.TabIndex = 15;
            this.searchIcon.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteBtn.IconColor = System.Drawing.Color.White;
            this.deleteBtn.IconSize = 30;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(7, 172);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(185, 48);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.editBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editBtn.IconColor = System.Drawing.Color.White;
            this.editBtn.IconSize = 40;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(7, 118);
            this.editBtn.Name = "editBtn";
            this.editBtn.Rotation = 0D;
            this.editBtn.Size = new System.Drawing.Size(185, 48);
            this.editBtn.TabIndex = 16;
            this.editBtn.Text = "EDIT";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(407, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(120, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(120, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(120, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = ":";
            // 
            // nama_TextBox
            // 
            this.nama_TextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_TextBox.Location = new System.Drawing.Point(139, 50);
            this.nama_TextBox.Name = "nama_TextBox";
            this.nama_TextBox.Size = new System.Drawing.Size(135, 27);
            this.nama_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nomor HP";
            // 
            // nomorHP_TextBox
            // 
            this.nomorHP_TextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorHP_TextBox.Location = new System.Drawing.Point(139, 92);
            this.nomorHP_TextBox.Name = "nomorHP_TextBox";
            this.nomorHP_TextBox.Size = new System.Drawing.Size(135, 27);
            this.nomorHP_TextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat";
            // 
            // alamat_TextBox
            // 
            this.alamat_TextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_TextBox.Location = new System.Drawing.Point(139, 132);
            this.alamat_TextBox.Name = "alamat_TextBox";
            this.alamat_TextBox.Size = new System.Drawing.Size(135, 27);
            this.alamat_TextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Transaksi";
            // 
            // label_IDTrans
            // 
            this.label_IDTrans.AutoSize = true;
            this.label_IDTrans.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDTrans.Location = new System.Drawing.Point(135, 17);
            this.label_IDTrans.Name = "label_IDTrans";
            this.label_IDTrans.Size = new System.Drawing.Size(15, 19);
            this.label_IDTrans.TabIndex = 0;
            this.label_IDTrans.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tanggal Jual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Harga Jual";
            // 
            // hargaJual_TextBox
            // 
            this.hargaJual_TextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaJual_TextBox.Location = new System.Drawing.Point(426, 92);
            this.hargaJual_TextBox.Name = "hargaJual_TextBox";
            this.hargaJual_TextBox.Size = new System.Drawing.Size(135, 27);
            this.hargaJual_TextBox.TabIndex = 1;
            // 
            // button_Batal
            // 
            this.button_Batal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Batal.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Batal.Location = new System.Drawing.Point(710, 60);
            this.button_Batal.Name = "button_Batal";
            this.button_Batal.Size = new System.Drawing.Size(93, 33);
            this.button_Batal.TabIndex = 2;
            this.button_Batal.TabStop = false;
            this.button_Batal.Text = "Batal";
            this.button_Batal.UseVisualStyleBackColor = false;
            this.button_Batal.Click += new System.EventHandler(this.button_Batal_Click);
            // 
            // button_Simpan
            // 
            this.button_Simpan.BackColor = System.Drawing.Color.Red;
            this.button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Simpan.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Simpan.Location = new System.Drawing.Point(600, 60);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(93, 33);
            this.button_Simpan.TabIndex = 2;
            this.button_Simpan.TabStop = false;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = false;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // tanggalJual_datePicker
            // 
            this.tanggalJual_datePicker.CalendarFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalJual_datePicker.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalJual_datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggalJual_datePicker.Location = new System.Drawing.Point(426, 50);
            this.tanggalJual_datePicker.Name = "tanggalJual_datePicker";
            this.tanggalJual_datePicker.Size = new System.Drawing.Size(135, 27);
            this.tanggalJual_datePicker.TabIndex = 3;
            this.tanggalJual_datePicker.TabStop = false;
            this.tanggalJual_datePicker.UseWaitCursor = true;
            this.tanggalJual_datePicker.Value = new System.DateTime(2020, 5, 19, 5, 41, 5, 0);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(600, 28);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 19);
            this.infoLabel.TabIndex = 4;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.infoLabel);
            this.panelInput.Controls.Add(this.tanggalJual_datePicker);
            this.panelInput.Controls.Add(this.button_Simpan);
            this.panelInput.Controls.Add(this.button_Batal);
            this.panelInput.Controls.Add(this.hargaJual_TextBox);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label_IDTrans);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.alamat_TextBox);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.nomorHP_TextBox);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.nama_TextBox);
            this.panelInput.Controls.Add(this.label18);
            this.panelInput.Controls.Add(this.label13);
            this.panelInput.Controls.Add(this.label15);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label12);
            this.panelInput.Controls.Add(this.label16);
            this.panelInput.Controls.Add(this.label11);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Location = new System.Drawing.Point(12, 346);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(806, 215);
            this.panelInput.TabIndex = 14;
            // 
            // TransaksiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.cari_TextBox);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.trans_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiUI";
            this.Text = "Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.trans_dataGridView)).EndInit();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView trans_dataGridView;
        private System.Windows.Forms.TextBox cari_TextBox;
        public System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelSide;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox nama_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomorHP_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alamat_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_IDTrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hargaJual_TextBox;
        private System.Windows.Forms.Button button_Batal;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.DateTimePicker tanggalJual_datePicker;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel panelInput;
    }
}
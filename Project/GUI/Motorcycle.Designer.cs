namespace Project.GUI
{
    partial class Motorcycle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMotor = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.soldBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dateTanggalBeli = new System.Windows.Forms.DateTimePicker();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Batal = new System.Windows.Forms.Button();
            this.textBox_InputHargaBeli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_IDMotor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_InputPlatNomor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_InputTahun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_InputTipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_InputMerk = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotor)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMotor
            // 
            this.dataGridViewMotor.AllowUserToAddRows = false;
            this.dataGridViewMotor.AllowUserToDeleteRows = false;
            this.dataGridViewMotor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMotor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMotor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMotor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMotor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMotor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "Data Kosong";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMotor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMotor.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMotor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMotor.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewMotor.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewMotor.Name = "dataGridViewMotor";
            this.dataGridViewMotor.ReadOnly = true;
            this.dataGridViewMotor.Size = new System.Drawing.Size(806, 292);
            this.dataGridViewMotor.TabIndex = 6;
            // 
            // panelButton
            // 
            this.panelButton.AutoSize = true;
            this.panelButton.BackColor = System.Drawing.Color.Maroon;
            this.panelButton.Controls.Add(this.addBtn);
            this.panelButton.Controls.Add(this.soldBtn);
            this.panelButton.Controls.Add(this.deleteBtn);
            this.panelButton.Controls.Add(this.editBtn);
            this.panelButton.Controls.Add(this.panelSide);
            this.panelButton.Location = new System.Drawing.Point(825, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(201, 562);
            this.panelButton.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Maroon;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBtn.IconColor = System.Drawing.Color.White;
            this.addBtn.IconSize = 30;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(7, 118);
            this.addBtn.Name = "addBtn";
            this.addBtn.Rotation = 0D;
            this.addBtn.Size = new System.Drawing.Size(185, 48);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "ADD";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addButton_Click);
            // 
            // soldBtn
            // 
            this.soldBtn.FlatAppearance.BorderSize = 0;
            this.soldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.soldBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldBtn.ForeColor = System.Drawing.Color.White;
            this.soldBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.soldBtn.IconColor = System.Drawing.Color.White;
            this.soldBtn.IconSize = 30;
            this.soldBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soldBtn.Location = new System.Drawing.Point(7, 280);
            this.soldBtn.Name = "soldBtn";
            this.soldBtn.Rotation = 0D;
            this.soldBtn.Size = new System.Drawing.Size(185, 48);
            this.soldBtn.TabIndex = 4;
            this.soldBtn.Text = "SOLD OUT";
            this.soldBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.soldBtn.UseVisualStyleBackColor = true;
            this.soldBtn.Click += new System.EventHandler(this.soldBtn_Click);
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
            this.deleteBtn.IconSize = 28;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(7, 226);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(185, 48);
            this.deleteBtn.TabIndex = 3;
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
            this.editBtn.IconSize = 38;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(7, 172);
            this.editBtn.Name = "editBtn";
            this.editBtn.Rotation = 0D;
            this.editBtn.Size = new System.Drawing.Size(185, 48);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "EDIT";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 118);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(197, 48);
            this.panelSide.TabIndex = 6;
            // 
            // panelInput
            // 
            this.panelInput.AutoSize = true;
            this.panelInput.Controls.Add(this.infoLabel);
            this.panelInput.Controls.Add(this.dateTanggalBeli);
            this.panelInput.Controls.Add(this.button_Simpan);
            this.panelInput.Controls.Add(this.button_Batal);
            this.panelInput.Controls.Add(this.textBox_InputHargaBeli);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label_IDMotor);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.textBox_InputPlatNomor);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.textBox_InputTahun);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.textBox_InputTipe);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.textBox_InputMerk);
            this.panelInput.Controls.Add(this.label18);
            this.panelInput.Controls.Add(this.label13);
            this.panelInput.Controls.Add(this.label15);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label12);
            this.panelInput.Controls.Add(this.label16);
            this.panelInput.Controls.Add(this.label14);
            this.panelInput.Controls.Add(this.label11);
            this.panelInput.Controls.Add(this.label10);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Location = new System.Drawing.Point(12, 346);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(806, 215);
            this.panelInput.TabIndex = 10;
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
            // dateTanggalBeli
            // 
            this.dateTanggalBeli.CalendarFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalBeli.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTanggalBeli.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggalBeli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTanggalBeli.Location = new System.Drawing.Point(419, 101);
            this.dateTanggalBeli.Name = "dateTanggalBeli";
            this.dateTanggalBeli.Size = new System.Drawing.Size(135, 25);
            this.dateTanggalBeli.TabIndex = 5;
            this.dateTanggalBeli.Value = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            // 
            // button_Simpan
            // 
            this.button_Simpan.BackColor = System.Drawing.Color.Red;
            this.button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Simpan.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Simpan.Location = new System.Drawing.Point(600, 60);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(93, 33);
            this.button_Simpan.TabIndex = 7;
            this.button_Simpan.TabStop = false;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = false;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Batal
            // 
            this.button_Batal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Batal.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Batal.Location = new System.Drawing.Point(710, 60);
            this.button_Batal.Name = "button_Batal";
            this.button_Batal.Size = new System.Drawing.Size(93, 33);
            this.button_Batal.TabIndex = 8;
            this.button_Batal.TabStop = false;
            this.button_Batal.Text = "Batal";
            this.button_Batal.UseVisualStyleBackColor = false;
            this.button_Batal.Click += new System.EventHandler(this.button_Batal_Click);
            // 
            // textBox_InputHargaBeli
            // 
            this.textBox_InputHargaBeli.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputHargaBeli.Location = new System.Drawing.Point(419, 142);
            this.textBox_InputHargaBeli.Name = "textBox_InputHargaBeli";
            this.textBox_InputHargaBeli.Size = new System.Drawing.Size(135, 27);
            this.textBox_InputHargaBeli.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Harga Beli";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tanggal Beli";
            // 
            // label_IDMotor
            // 
            this.label_IDMotor.AutoSize = true;
            this.label_IDMotor.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDMotor.Location = new System.Drawing.Point(123, 28);
            this.label_IDMotor.Name = "label_IDMotor";
            this.label_IDMotor.Size = new System.Drawing.Size(15, 19);
            this.label_IDMotor.TabIndex = 0;
            this.label_IDMotor.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Motor";
            // 
            // textBox_InputPlatNomor
            // 
            this.textBox_InputPlatNomor.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPlatNomor.Location = new System.Drawing.Point(419, 60);
            this.textBox_InputPlatNomor.Name = "textBox_InputPlatNomor";
            this.textBox_InputPlatNomor.Size = new System.Drawing.Size(135, 27);
            this.textBox_InputPlatNomor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Plat Nomor";
            // 
            // textBox_InputTahun
            // 
            this.textBox_InputTahun.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputTahun.Location = new System.Drawing.Point(127, 142);
            this.textBox_InputTahun.Name = "textBox_InputTahun";
            this.textBox_InputTahun.Size = new System.Drawing.Size(135, 27);
            this.textBox_InputTahun.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tahun";
            // 
            // textBox_InputTipe
            // 
            this.textBox_InputTipe.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputTipe.Location = new System.Drawing.Point(127, 102);
            this.textBox_InputTipe.Name = "textBox_InputTipe";
            this.textBox_InputTipe.Size = new System.Drawing.Size(135, 27);
            this.textBox_InputTipe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipe";
            // 
            // textBox_InputMerk
            // 
            this.textBox_InputMerk.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputMerk.Location = new System.Drawing.Point(127, 60);
            this.textBox_InputMerk.Name = "textBox_InputMerk";
            this.textBox_InputMerk.Size = new System.Drawing.Size(135, 27);
            this.textBox_InputMerk.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(108, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(108, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(108, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(400, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(400, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk";
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.ForeColor = System.Drawing.Color.Silver;
            this.searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchIcon.IconColor = System.Drawing.Color.Silver;
            this.searchIcon.IconSize = 30;
            this.searchIcon.Location = new System.Drawing.Point(16, 15);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 30);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchIcon.TabIndex = 11;
            this.searchIcon.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(13, 12);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(806, 35);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // Motorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.dataGridViewMotor);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Motorcycle";
            this.Text = "Motor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotor)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewMotor;
        public System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button button_Batal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_IDMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_InputPlatNomor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_InputTahun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_InputTipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_InputMerk;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.TextBox textBox_InputHargaBeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.DateTimePicker dateTanggalBeli;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton addBtn;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private System.Windows.Forms.TextBox searchTextBox;
        private FontAwesome.Sharp.IconButton soldBtn;
    }
}
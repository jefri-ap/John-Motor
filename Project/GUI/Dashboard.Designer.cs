namespace Project.GUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelButtonMain = new System.Windows.Forms.Panel();
            this.reportBtn = new FontAwesome.Sharp.IconButton();
            this.transBtn = new FontAwesome.Sharp.IconButton();
            this.mtrBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.miniMizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelUtama = new System.Windows.Forms.Panel();
            this.panelButtonMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtonMain
            // 
            this.panelButtonMain.BackColor = System.Drawing.Color.Maroon;
            this.panelButtonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelButtonMain.Controls.Add(this.reportBtn);
            this.panelButtonMain.Controls.Add(this.transBtn);
            this.panelButtonMain.Controls.Add(this.mtrBtn);
            this.panelButtonMain.Controls.Add(this.homeBtn);
            this.panelButtonMain.Controls.Add(this.sidePanel);
            this.panelButtonMain.Controls.Add(this.label3);
            this.panelButtonMain.Controls.Add(this.label2);
            this.panelButtonMain.Controls.Add(this.pictureBox1);
            this.panelButtonMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonMain.Location = new System.Drawing.Point(0, 0);
            this.panelButtonMain.Name = "panelButtonMain";
            this.panelButtonMain.Size = new System.Drawing.Size(175, 587);
            this.panelButtonMain.TabIndex = 0;
            // 
            // reportBtn
            // 
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.reportBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.reportBtn.IconColor = System.Drawing.Color.White;
            this.reportBtn.IconSize = 35;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(6, 301);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Rotation = 0D;
            this.reportBtn.Size = new System.Drawing.Size(163, 50);
            this.reportBtn.TabIndex = 18;
            this.reportBtn.Text = "REPORT";
            this.reportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // transBtn
            // 
            this.transBtn.FlatAppearance.BorderSize = 0;
            this.transBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.transBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transBtn.ForeColor = System.Drawing.Color.White;
            this.transBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.transBtn.IconColor = System.Drawing.Color.White;
            this.transBtn.IconSize = 35;
            this.transBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transBtn.Location = new System.Drawing.Point(6, 244);
            this.transBtn.Name = "transBtn";
            this.transBtn.Rotation = 0D;
            this.transBtn.Size = new System.Drawing.Size(163, 50);
            this.transBtn.TabIndex = 18;
            this.transBtn.Text = "TRANSACTION";
            this.transBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transBtn.UseVisualStyleBackColor = true;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // mtrBtn
            // 
            this.mtrBtn.FlatAppearance.BorderSize = 0;
            this.mtrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mtrBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.mtrBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrBtn.ForeColor = System.Drawing.Color.White;
            this.mtrBtn.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.mtrBtn.IconColor = System.Drawing.Color.White;
            this.mtrBtn.IconSize = 35;
            this.mtrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtrBtn.Location = new System.Drawing.Point(6, 187);
            this.mtrBtn.Name = "mtrBtn";
            this.mtrBtn.Rotation = 0D;
            this.mtrBtn.Size = new System.Drawing.Size(163, 50);
            this.mtrBtn.TabIndex = 18;
            this.mtrBtn.Text = "MOTORCYCLE";
            this.mtrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mtrBtn.UseVisualStyleBackColor = true;
            this.mtrBtn.Click += new System.EventHandler(this.mtrBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.homeBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.White;
            this.homeBtn.IconSize = 35;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(6, 130);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Rotation = 0D;
            this.homeBtn.Size = new System.Drawing.Size(163, 50);
            this.homeBtn.TabIndex = 18;
            this.homeBtn.Text = "HOME";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidePanel.Location = new System.Drawing.Point(0, 130);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 50);
            this.sidePanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bodoni Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Motor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bodoni Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jhon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.miniMizeButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 25);
            this.panel2.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(456, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(999, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // miniMizeButton
            // 
            this.miniMizeButton.BackColor = System.Drawing.Color.White;
            this.miniMizeButton.FlatAppearance.BorderSize = 0;
            this.miniMizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniMizeButton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniMizeButton.ForeColor = System.Drawing.Color.Black;
            this.miniMizeButton.Location = new System.Drawing.Point(973, 0);
            this.miniMizeButton.Name = "miniMizeButton";
            this.miniMizeButton.Size = new System.Drawing.Size(25, 25);
            this.miniMizeButton.TabIndex = 5;
            this.miniMizeButton.Text = "-";
            this.miniMizeButton.UseVisualStyleBackColor = false;
            this.miniMizeButton.Click += new System.EventHandler(this.miniMizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(972, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 25);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1020, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 25);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(996, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 25);
            this.panel4.TabIndex = 6;
            // 
            // panelUtama
            // 
            this.panelUtama.BackColor = System.Drawing.Color.White;
            this.panelUtama.Location = new System.Drawing.Point(175, 25);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(1025, 562);
            this.panelUtama.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 587);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelButtonMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panelButtonMain.ResumeLayout(false);
            this.panelButtonMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelButtonMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUtama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button miniMizeButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton reportBtn;
        private FontAwesome.Sharp.IconButton transBtn;
        private FontAwesome.Sharp.IconButton mtrBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}
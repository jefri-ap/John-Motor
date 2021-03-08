namespace Project.DAO
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bgImage = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.miniMizeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.unameTextBox = new System.Windows.Forms.TextBox();
            this.bgImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgImage
            // 
            this.bgImage.BackColor = System.Drawing.Color.Transparent;
            this.bgImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgImage.BackgroundImage")));
            this.bgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bgImage.Controls.Add(this.closeButton);
            this.bgImage.Controls.Add(this.miniMizeButton);
            this.bgImage.Controls.Add(this.panel2);
            this.bgImage.Controls.Add(this.panel1);
            this.bgImage.Location = new System.Drawing.Point(-1, -1);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(630, 276);
            this.bgImage.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.LightGray;
            this.closeButton.Location = new System.Drawing.Point(603, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // miniMizeButton
            // 
            this.miniMizeButton.BackColor = System.Drawing.Color.DimGray;
            this.miniMizeButton.FlatAppearance.BorderSize = 0;
            this.miniMizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniMizeButton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniMizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.miniMizeButton.Location = new System.Drawing.Point(576, 0);
            this.miniMizeButton.Name = "miniMizeButton";
            this.miniMizeButton.Size = new System.Drawing.Size(25, 25);
            this.miniMizeButton.TabIndex = 2;
            this.miniMizeButton.Text = "-";
            this.miniMizeButton.UseVisualStyleBackColor = false;
            this.miniMizeButton.Click += new System.EventHandler(this.miniMizeButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 25);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 100);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sistem Informasi \r\nPencatatan Motor dan Keuangan Showroom Jual-Beli Motor Second";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordBox.Location = new System.Drawing.Point(233, 321);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(139, 23);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.Text = "Password";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Show_Hide.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide.ForeColor = System.Drawing.Color.White;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(380, 324);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(101, 17);
            this.checkBox_Show_Hide.TabIndex = 6;
            this.checkBox_Show_Hide.Text = "Show Password";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DimGray;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.loginBtn.Font = new System.Drawing.Font("Lato Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.loginBtn.IconColor = System.Drawing.Color.White;
            this.loginBtn.IconSize = 25;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(233, 350);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Rotation = 0D;
            this.loginBtn.Size = new System.Drawing.Size(98, 27);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // unameTextBox
            // 
            this.unameTextBox.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.unameTextBox.Location = new System.Drawing.Point(233, 292);
            this.unameTextBox.Multiline = true;
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.Size = new System.Drawing.Size(140, 23);
            this.unameTextBox.TabIndex = 3;
            this.unameTextBox.Text = "Username";
            this.unameTextBox.Enter += new System.EventHandler(this.unameTextBox_Enter);
            this.unameTextBox.Leave += new System.EventHandler(this.unameTextBox_Leave);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.bgImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bgImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bgImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button miniMizeButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton loginBtn;
        private System.Windows.Forms.TextBox unameTextBox;
    }
}
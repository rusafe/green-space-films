namespace ProyectoGreenSpace
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.gBoxSwitchNightDay = new System.Windows.Forms.GroupBox();
            this.btnDayMode = new System.Windows.Forms.Button();
            this.btnNightMode = new System.Windows.Forms.Button();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPredet = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnEspanol = new System.Windows.Forms.Button();
            this.lblChangeLanguage = new System.Windows.Forms.Label();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gBoxSwitchNightDay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Location = new System.Drawing.Point(18, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 180);
            this.panel1.TabIndex = 35;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccount.Location = new System.Drawing.Point(0, 127);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(261, 53);
            this.btnAccount.TabIndex = 13;
            this.btnAccount.Text = "Cuenta";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Location = new System.Drawing.Point(0, 64);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 53);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(261, 53);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // gBoxSwitchNightDay
            // 
            this.gBoxSwitchNightDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gBoxSwitchNightDay.Controls.Add(this.btnDayMode);
            this.gBoxSwitchNightDay.Controls.Add(this.btnNightMode);
            this.gBoxSwitchNightDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSwitchNightDay.Location = new System.Drawing.Point(411, 234);
            this.gBoxSwitchNightDay.Name = "gBoxSwitchNightDay";
            this.gBoxSwitchNightDay.Size = new System.Drawing.Size(438, 121);
            this.gBoxSwitchNightDay.TabIndex = 34;
            this.gBoxSwitchNightDay.TabStop = false;
            this.gBoxSwitchNightDay.Text = "Elige el tipo de modo:";
            // 
            // btnDayMode
            // 
            this.btnDayMode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDayMode.Location = new System.Drawing.Point(0, 47);
            this.btnDayMode.Name = "btnDayMode";
            this.btnDayMode.Size = new System.Drawing.Size(215, 72);
            this.btnDayMode.TabIndex = 6;
            this.btnDayMode.Text = "Modo Diurno";
            this.btnDayMode.UseVisualStyleBackColor = false;
            // 
            // btnNightMode
            // 
            this.btnNightMode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNightMode.Location = new System.Drawing.Point(214, 47);
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.Size = new System.Drawing.Size(224, 74);
            this.btnNightMode.TabIndex = 7;
            this.btnNightMode.Text = "Modo Noche";
            this.btnNightMode.UseVisualStyleBackColor = false;
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Location = new System.Drawing.Point(408, 417);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(218, 16);
            this.lblDeleteAccount.TabIndex = 33;
            this.lblDeleteAccount.Text = "\"Aqui se cargara el correo a borrar\"";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(529, 463);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(168, 53);
            this.btnDeleteAccount.TabIndex = 32;
            this.btnDeleteAccount.Text = "Eliminar Cuenta";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDeleteUser.Location = new System.Drawing.Point(406, 370);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(172, 25);
            this.lblDeleteUser.TabIndex = 31;
            this.lblDeleteUser.Text = "Eliminar Cuenta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPredet);
            this.groupBox1.Controls.Add(this.btnEnglish);
            this.groupBox1.Controls.Add(this.btnEspanol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(738, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 187);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idiomas:";
            // 
            // btnPredet
            // 
            this.btnPredet.BackColor = System.Drawing.Color.White;
            this.btnPredet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPredet.Location = new System.Drawing.Point(0, 29);
            this.btnPredet.Name = "btnPredet";
            this.btnPredet.Size = new System.Drawing.Size(155, 53);
            this.btnPredet.TabIndex = 14;
            this.btnPredet.Text = "Predet.";
            this.btnPredet.UseVisualStyleBackColor = false;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.White;
            this.btnEnglish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnglish.Location = new System.Drawing.Point(0, 132);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(155, 53);
            this.btnEnglish.TabIndex = 16;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            // 
            // btnEspanol
            // 
            this.btnEspanol.BackColor = System.Drawing.Color.White;
            this.btnEspanol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEspanol.Location = new System.Drawing.Point(0, 81);
            this.btnEspanol.Name = "btnEspanol";
            this.btnEspanol.Size = new System.Drawing.Size(155, 53);
            this.btnEspanol.TabIndex = 15;
            this.btnEspanol.Text = "Español";
            this.btnEspanol.UseVisualStyleBackColor = false;
            // 
            // lblChangeLanguage
            // 
            this.lblChangeLanguage.AutoSize = true;
            this.lblChangeLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeLanguage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChangeLanguage.Location = new System.Drawing.Point(533, 50);
            this.lblChangeLanguage.Name = "lblChangeLanguage";
            this.lblChangeLanguage.Size = new System.Drawing.Size(170, 25);
            this.lblChangeLanguage.TabIndex = 29;
            this.lblChangeLanguage.Text = "Cambiar Idioma:";
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxIcono.Image")));
            this.pictBoxIcono.Location = new System.Drawing.Point(4, 417);
            this.pictBoxIcono.Name = "pictBoxIcono";
            this.pictBoxIcono.Size = new System.Drawing.Size(247, 211);
            this.pictBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxIcono.TabIndex = 28;
            this.pictBoxIcono.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(411, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 26;
            this.button1.Text = "Salir\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(633, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 53);
            this.button2.TabIndex = 27;
            this.button2.Text = "Guardar ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBoxSwitchNightDay);
            this.Controls.Add(this.lblDeleteAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblChangeLanguage);
            this.Controls.Add(this.pictBoxIcono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "FrmAccount";
            this.Text = "FrmCuenta";
            this.panel1.ResumeLayout(false);
            this.gBoxSwitchNightDay.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.GroupBox gBoxSwitchNightDay;
        private System.Windows.Forms.Button btnDayMode;
        private System.Windows.Forms.Button btnNightMode;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPredet;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnEspanol;
        private System.Windows.Forms.Label lblChangeLanguage;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
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
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.grpSwitchNightDay = new System.Windows.Forms.GroupBox();
            this.pibLightDark = new System.Windows.Forms.PictureBox();
            this.pibDarkMode = new System.Windows.Forms.PictureBox();
            this.pibLightMode = new System.Windows.Forms.PictureBox();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.btnPredet = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnEspanol = new System.Windows.Forms.Button();
            this.lblChangeLanguage = new System.Windows.Forms.Label();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSwitchNightDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccount.Location = new System.Drawing.Point(18, 185);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(261, 72);
            this.btnAccount.TabIndex = 13;
            this.btnAccount.Text = "Cuenta";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Location = new System.Drawing.Point(18, 109);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 70);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin.";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(18, 27);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(261, 76);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // grpSwitchNightDay
            // 
            this.grpSwitchNightDay.BackColor = System.Drawing.Color.Transparent;
            this.grpSwitchNightDay.Controls.Add(this.pibLightDark);
            this.grpSwitchNightDay.Controls.Add(this.pibDarkMode);
            this.grpSwitchNightDay.Controls.Add(this.pibLightMode);
            this.grpSwitchNightDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSwitchNightDay.Location = new System.Drawing.Point(367, 170);
            this.grpSwitchNightDay.Name = "grpSwitchNightDay";
            this.grpSwitchNightDay.Size = new System.Drawing.Size(350, 150);
            this.grpSwitchNightDay.TabIndex = 34;
            this.grpSwitchNightDay.TabStop = false;
            this.grpSwitchNightDay.Text = "Elige el tipo de modo:";
            // 
            // pibLightDark
            // 
            this.pibLightDark.Image = global::ProyectoGreenSpace.Properties.Resources.light_mode;
            this.pibLightDark.Location = new System.Drawing.Point(115, 44);
            this.pibLightDark.Name = "pibLightDark";
            this.pibLightDark.Size = new System.Drawing.Size(100, 80);
            this.pibLightDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLightDark.TabIndex = 2;
            this.pibLightDark.TabStop = false;
            // 
            // pibDarkMode
            // 
            this.pibDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDarkMode.Image = global::ProyectoGreenSpace.Properties.Resources.moon;
            this.pibDarkMode.Location = new System.Drawing.Point(233, 54);
            this.pibDarkMode.Name = "pibDarkMode";
            this.pibDarkMode.Size = new System.Drawing.Size(73, 63);
            this.pibDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibDarkMode.TabIndex = 1;
            this.pibDarkMode.TabStop = false;
            this.pibDarkMode.Click += new System.EventHandler(this.pibDarkMode_Click);
            // 
            // pibLightMode
            // 
            this.pibLightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibLightMode.Image = global::ProyectoGreenSpace.Properties.Resources.day_mode;
            this.pibLightMode.Location = new System.Drawing.Point(27, 54);
            this.pibLightMode.Name = "pibLightMode";
            this.pibLightMode.Size = new System.Drawing.Size(71, 63);
            this.pibLightMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLightMode.TabIndex = 0;
            this.pibLightMode.TabStop = false;
            this.pibLightMode.Click += new System.EventHandler(this.pibLightMode_Click);
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(488, 403);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(185, 23);
            this.lblDeleteAccount.TabIndex = 33;
            this.lblDeleteAccount.Text = "email@email.com";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(367, 451);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(204, 53);
            this.btnDeleteAccount.TabIndex = 32;
            this.btnDeleteAccount.Text = "Eliminar Cuenta";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDeleteUser.Location = new System.Drawing.Point(370, 368);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(297, 23);
            this.lblDeleteUser.TabIndex = 31;
            this.lblDeleteUser.Text = "Cuenta asociada de correo: ";
            // 
            // btnPredet
            // 
            this.btnPredet.BackColor = System.Drawing.Color.White;
            this.btnPredet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPredet.Location = new System.Drawing.Point(579, 12);
            this.btnPredet.Name = "btnPredet";
            this.btnPredet.Size = new System.Drawing.Size(155, 40);
            this.btnPredet.TabIndex = 14;
            this.btnPredet.Text = "Predet.";
            this.btnPredet.UseVisualStyleBackColor = false;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.White;
            this.btnEnglish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnglish.Location = new System.Drawing.Point(579, 104);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(155, 39);
            this.btnEnglish.TabIndex = 16;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            // 
            // btnEspanol
            // 
            this.btnEspanol.BackColor = System.Drawing.Color.White;
            this.btnEspanol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspanol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEspanol.Location = new System.Drawing.Point(579, 58);
            this.btnEspanol.Name = "btnEspanol";
            this.btnEspanol.Size = new System.Drawing.Size(155, 40);
            this.btnEspanol.TabIndex = 15;
            this.btnEspanol.Text = "Español";
            this.btnEspanol.UseVisualStyleBackColor = false;
            // 
            // lblChangeLanguage
            // 
            this.lblChangeLanguage.AutoSize = true;
            this.lblChangeLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeLanguage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChangeLanguage.Location = new System.Drawing.Point(363, 40);
            this.lblChangeLanguage.Name = "lblChangeLanguage";
            this.lblChangeLanguage.Size = new System.Drawing.Size(175, 23);
            this.lblChangeLanguage.TabIndex = 29;
            this.lblChangeLanguage.Text = "Cambiar Idioma:";
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxIcono.Image")));
            this.pictBoxIcono.Location = new System.Drawing.Point(44, 356);
            this.pictBoxIcono.Name = "pictBoxIcono";
            this.pictBoxIcono.Size = new System.Drawing.Size(186, 160);
            this.pictBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxIcono.TabIndex = 28;
            this.pictBoxIcono.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(549, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 53);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 592);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnPredet);
            this.Controls.Add(this.btnEspanol);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.grpSwitchNightDay);
            this.Controls.Add(this.lblDeleteAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.lblChangeLanguage);
            this.Controls.Add(this.pictBoxIcono);
            this.Name = "FrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuenta";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.grpSwitchNightDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibLightDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.GroupBox grpSwitchNightDay;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.Button btnPredet;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnEspanol;
        private System.Windows.Forms.Label lblChangeLanguage;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.PictureBox pibLightDark;
        private System.Windows.Forms.PictureBox pibDarkMode;
        private System.Windows.Forms.PictureBox pibLightMode;
        private System.Windows.Forms.Button btnExit;
    }
}
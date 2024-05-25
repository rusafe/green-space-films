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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.grpSwitchNightDay = new System.Windows.Forms.GroupBox();
            this.pibLightDark = new System.Windows.Forms.PictureBox();
            this.pibDarkMode = new System.Windows.Forms.PictureBox();
            this.pibLightMode = new System.Windows.Forms.PictureBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.lblChangeLanguage = new System.Windows.Forms.Label();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pibMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grpSwitchNightDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.g2Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccount.Location = new System.Drawing.Point(35, 220);
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
            this.btnAdmin.Location = new System.Drawing.Point(35, 144);
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
            this.btnUser.Location = new System.Drawing.Point(35, 62);
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
            this.grpSwitchNightDay.Location = new System.Drawing.Point(384, 205);
            this.grpSwitchNightDay.Name = "grpSwitchNightDay";
            this.grpSwitchNightDay.Size = new System.Drawing.Size(366, 150);
            this.grpSwitchNightDay.TabIndex = 34;
            this.grpSwitchNightDay.TabStop = false;
            this.grpSwitchNightDay.Text = "Elige el tipo de modo:";
            // 
            // pibLightDark
            // 
            this.pibLightDark.Image = global::ProyectoGreenSpace.Properties.Resources.light_mode;
            this.pibLightDark.Location = new System.Drawing.Point(115, 44);
            this.pibLightDark.Name = "pibLightDark";
            this.pibLightDark.Size = new System.Drawing.Size(123, 80);
            this.pibLightDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLightDark.TabIndex = 2;
            this.pibLightDark.TabStop = false;
            // 
            // pibDarkMode
            // 
            this.pibDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDarkMode.Image = global::ProyectoGreenSpace.Properties.Resources.moon;
            this.pibDarkMode.Location = new System.Drawing.Point(255, 54);
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
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(434, 488);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(204, 53);
            this.btnDeleteAccount.TabIndex = 32;
            this.btnDeleteAccount.Text = "Eliminar Cuenta";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDeleteUser.Location = new System.Drawing.Point(387, 403);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(297, 23);
            this.lblDeleteUser.TabIndex = 31;
            this.lblDeleteUser.Text = "Cuenta asociada de correo: ";
            // 
            // lblChangeLanguage
            // 
            this.lblChangeLanguage.AutoSize = true;
            this.lblChangeLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeLanguage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChangeLanguage.Location = new System.Drawing.Point(380, 75);
            this.lblChangeLanguage.Name = "lblChangeLanguage";
            this.lblChangeLanguage.Size = new System.Drawing.Size(175, 23);
            this.lblChangeLanguage.TabIndex = 29;
            this.lblChangeLanguage.Text = "Cambiar Idioma:";
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.Image = global::ProyectoGreenSpace.Properties.Resources.logo1;
            this.pictBoxIcono.Location = new System.Drawing.Point(61, 391);
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
            this.btnExit.Location = new System.Drawing.Point(566, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 53);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.g2Bar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Controls.Add(this.pibMinimize);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibClose);
            this.g2Bar.Location = new System.Drawing.Point(0, -1);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(785, 42);
            this.g2Bar.TabIndex = 48;
            // 
            // g2lblTitle
            // 
            this.g2lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.g2lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2lblTitle.Location = new System.Drawing.Point(13, 8);
            this.g2lblTitle.Name = "g2lblTitle";
            this.g2lblTitle.Size = new System.Drawing.Size(194, 25);
            this.g2lblTitle.TabIndex = 36;
            this.g2lblTitle.Text = "GREEN SPACE FILMS";
            // 
            // pibMinimize
            // 
            this.pibMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimize.Image")));
            this.pibMinimize.ImageRotate = 0F;
            this.pibMinimize.Location = new System.Drawing.Point(652, 8);
            this.pibMinimize.Name = "pibMinimize";
            this.pibMinimize.Size = new System.Drawing.Size(35, 25);
            this.pibMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMinimize.TabIndex = 35;
            this.pibMinimize.TabStop = false;
            this.pibMinimize.Click += new System.EventHandler(this.pibMinimize_Click);
            // 
            // pibMaximize
            // 
            this.pibMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximize.Image = global::ProyectoGreenSpace.Properties.Resources.maximizar;
            this.pibMaximize.ImageRotate = 0F;
            this.pibMaximize.Location = new System.Drawing.Point(694, 8);
            this.pibMaximize.Name = "pibMaximize";
            this.pibMaximize.Size = new System.Drawing.Size(34, 25);
            this.pibMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMaximize.TabIndex = 34;
            this.pibMaximize.TabStop = false;
            this.pibMaximize.Click += new System.EventHandler(this.pibMaximize_Click);
            // 
            // pibClose
            // 
            this.pibClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Image = ((System.Drawing.Image)(resources.GetObject("pibClose.Image")));
            this.pibClose.ImageRotate = 0F;
            this.pibClose.Location = new System.Drawing.Point(733, 3);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(39, 33);
            this.pibClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibClose.TabIndex = 33;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Castellano",
            "Inglés"});
            this.cmbLanguage.Location = new System.Drawing.Point(607, 75);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(143, 31);
            this.cmbLanguage.TabIndex = 49;
            this.cmbLanguage.Text = "Castellano";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(411, 439);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(256, 32);
            this.txtMail.TabIndex = 53;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 641);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.grpSwitchNightDay);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.lblChangeLanguage);
            this.Controls.Add(this.pictBoxIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuenta";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.grpSwitchNightDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibLightDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLightMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.GroupBox grpSwitchNightDay;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.Label lblChangeLanguage;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.PictureBox pibLightDark;
        private System.Windows.Forms.PictureBox pibDarkMode;
        private System.Windows.Forms.PictureBox pibLightMode;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pibMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibClose;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TextBox txtMail;
    }
}
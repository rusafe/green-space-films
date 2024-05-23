namespace ProyectoGreenSpace
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.grpBoxAdmin = new System.Windows.Forms.GroupBox();
            this.linklblForgotPass = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMailUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pibMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.grpBoxAdmin.SuspendLayout();
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
            this.btnAccount.Location = new System.Drawing.Point(27, 227);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(261, 83);
            this.btnAccount.TabIndex = 13;
            this.btnAccount.Text = "Cuenta";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Location = new System.Drawing.Point(27, 147);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 74);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin.";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(27, 61);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(261, 80);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click_1);
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxIcono.Image")));
            this.pictBoxIcono.Location = new System.Drawing.Point(51, 364);
            this.pictBoxIcono.Name = "pictBoxIcono";
            this.pictBoxIcono.Size = new System.Drawing.Size(190, 151);
            this.pictBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxIcono.TabIndex = 19;
            this.pictBoxIcono.TabStop = false;
            // 
            // grpBoxAdmin
            // 
            this.grpBoxAdmin.BackColor = System.Drawing.Color.White;
            this.grpBoxAdmin.Controls.Add(this.linklblForgotPass);
            this.grpBoxAdmin.Controls.Add(this.lblPassword);
            this.grpBoxAdmin.Controls.Add(this.lblMailUser);
            this.grpBoxAdmin.Controls.Add(this.btnLogin);
            this.grpBoxAdmin.Controls.Add(this.txtPassword);
            this.grpBoxAdmin.Controls.Add(this.txtUser);
            this.grpBoxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAdmin.Location = new System.Drawing.Point(346, 79);
            this.grpBoxAdmin.Name = "grpBoxAdmin";
            this.grpBoxAdmin.Size = new System.Drawing.Size(471, 333);
            this.grpBoxAdmin.TabIndex = 18;
            this.grpBoxAdmin.TabStop = false;
            // 
            // linklblForgotPass
            // 
            this.linklblForgotPass.AutoSize = true;
            this.linklblForgotPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblForgotPass.LinkColor = System.Drawing.Color.SlateBlue;
            this.linklblForgotPass.Location = new System.Drawing.Point(60, 206);
            this.linklblForgotPass.Name = "linklblForgotPass";
            this.linklblForgotPass.Size = new System.Drawing.Size(308, 23);
            this.linklblForgotPass.TabIndex = 22;
            this.linklblForgotPass.TabStop = true;
            this.linklblForgotPass.Text = "¿Has olvidado la contraseña?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPassword.Location = new System.Drawing.Point(48, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(144, 23);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "CONTRASEÑA";
            // 
            // lblMailUser
            // 
            this.lblMailUser.AutoSize = true;
            this.lblMailUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMailUser.Location = new System.Drawing.Point(43, 37);
            this.lblMailUser.Name = "lblMailUser";
            this.lblMailUser.Size = new System.Drawing.Size(344, 23);
            this.lblMailUser.TabIndex = 10;
            this.lblMailUser.Text = "CORREO ELECTRÓNICO / USUARIO";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(364, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(52, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(363, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(48, 70);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(367, 32);
            this.txtUser.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(649, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 53);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Controls.Add(this.pibMinimize);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibClose);
            this.g2Bar.Location = new System.Drawing.Point(0, 0);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(843, 43);
            this.g2Bar.TabIndex = 49;
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
            this.pibMinimize.Location = new System.Drawing.Point(710, 8);
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
            this.pibMaximize.Location = new System.Drawing.Point(752, 8);
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
            this.pibClose.Location = new System.Drawing.Point(791, 3);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(39, 33);
            this.pibClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibClose.TabIndex = 33;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.g2Bar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.pictBoxIcono);
            this.Controls.Add(this.grpBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.grpBoxAdmin.ResumeLayout(false);
            this.grpBoxAdmin.PerformLayout();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.GroupBox grpBoxAdmin;
        private System.Windows.Forms.LinkLabel linklblForgotPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMailUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pibMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
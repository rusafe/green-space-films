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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.grpBoxAdmin = new System.Windows.Forms.GroupBox();
            this.linklblForgotPass = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCorreoUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtboxCorreoUser = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.grpBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 180);
            this.panel1.TabIndex = 20;
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
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxIcono.Image")));
            this.pictBoxIcono.Location = new System.Drawing.Point(20, 325);
            this.pictBoxIcono.Name = "pictBoxIcono";
            this.pictBoxIcono.Size = new System.Drawing.Size(247, 211);
            this.pictBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxIcono.TabIndex = 19;
            this.pictBoxIcono.TabStop = false;
            // 
            // grpBoxAdmin
            // 
            this.grpBoxAdmin.BackColor = System.Drawing.Color.SpringGreen;
            this.grpBoxAdmin.Controls.Add(this.linklblForgotPass);
            this.grpBoxAdmin.Controls.Add(this.lblPassword);
            this.grpBoxAdmin.Controls.Add(this.lblCorreoUser);
            this.grpBoxAdmin.Controls.Add(this.btnLogin);
            this.grpBoxAdmin.Controls.Add(this.txtBoxContraseña);
            this.grpBoxAdmin.Controls.Add(this.txtboxCorreoUser);
            this.grpBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAdmin.Location = new System.Drawing.Point(351, 40);
            this.grpBoxAdmin.Name = "grpBoxAdmin";
            this.grpBoxAdmin.Size = new System.Drawing.Size(471, 307);
            this.grpBoxAdmin.TabIndex = 18;
            this.grpBoxAdmin.TabStop = false;
            this.grpBoxAdmin.Text = "Datos de Admin";
            // 
            // linklblForgotPass
            // 
            this.linklblForgotPass.AutoSize = true;
            this.linklblForgotPass.Location = new System.Drawing.Point(49, 190);
            this.linklblForgotPass.Name = "linklblForgotPass";
            this.linklblForgotPass.Size = new System.Drawing.Size(298, 25);
            this.linklblForgotPass.TabIndex = 22;
            this.linklblForgotPass.TabStop = true;
            this.linklblForgotPass.Text = "¿Has olvidado la contraseña?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPassword.Location = new System.Drawing.Point(47, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 25);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblCorreoUser
            // 
            this.lblCorreoUser.AutoSize = true;
            this.lblCorreoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCorreoUser.Location = new System.Drawing.Point(43, 37);
            this.lblCorreoUser.Name = "lblCorreoUser";
            this.lblCorreoUser.Size = new System.Drawing.Size(291, 25);
            this.lblCorreoUser.TabIndex = 10;
            this.lblCorreoUser.Text = "Correo Electrónico / Usuario:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(139, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(52, 149);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.Size = new System.Drawing.Size(363, 30);
            this.txtBoxContraseña.TabIndex = 1;
            // 
            // txtboxCorreoUser
            // 
            this.txtboxCorreoUser.Location = new System.Drawing.Point(48, 70);
            this.txtboxCorreoUser.Name = "txtboxCorreoUser";
            this.txtboxCorreoUser.Size = new System.Drawing.Size(367, 30);
            this.txtboxCorreoUser.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Cyan;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(654, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 53);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(432, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 53);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Salir\r\n";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictBoxIcono);
            this.Controls.Add(this.grpBoxAdmin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.grpBoxAdmin.ResumeLayout(false);
            this.grpBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.GroupBox grpBoxAdmin;
        private System.Windows.Forms.LinkLabel linklblForgotPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCorreoUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.TextBox txtboxCorreoUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}
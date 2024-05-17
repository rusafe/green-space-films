namespace ProyectoGreenSpace
{
    partial class FrmLogin
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lkllblRecoverPassword = new System.Windows.Forms.LinkLabel();
            this.lklblRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblInfoRegister = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pibSpanish = new System.Windows.Forms.PictureBox();
            this.pibBritish = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSpanish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBritish)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lkllblRecoverPassword);
            this.grpLogin.Controls.Add(this.lklblRegister);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.lblInfoRegister);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(27, 33);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(545, 389);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.grpLogin_Paint);
            // 
            // lkllblRecoverPassword
            // 
            this.lkllblRecoverPassword.AutoSize = true;
            this.lkllblRecoverPassword.Location = new System.Drawing.Point(41, 203);
            this.lkllblRecoverPassword.Name = "lkllblRecoverPassword";
            this.lkllblRecoverPassword.Size = new System.Drawing.Size(308, 23);
            this.lkllblRecoverPassword.TabIndex = 9;
            this.lkllblRecoverPassword.TabStop = true;
            this.lkllblRecoverPassword.Text = "¿Has olvidado la contraseña?";
            this.toolTip1.SetToolTip(this.lkllblRecoverPassword, "Recuperar la contraseña");
            this.lkllblRecoverPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkllblRecoverPassword_LinkClicked);
            // 
            // lklblRegister
            // 
            this.lklblRegister.AutoSize = true;
            this.lklblRegister.Location = new System.Drawing.Point(403, 310);
            this.lklblRegister.Name = "lklblRegister";
            this.lklblRegister.Size = new System.Drawing.Size(113, 23);
            this.lklblRegister.TabIndex = 8;
            this.lklblRegister.TabStop = true;
            this.lklblRegister.Text = "Registrarse";
            this.toolTip1.SetToolTip(this.lklblRegister, "Crear cuenta nueva. ");
            this.lklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRegister_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(295, 46);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLogin_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(45, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 32);
            this.txtPassword.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtPassword, "Introduce tú contraseña.");
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(45, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 32);
            this.txtUsername.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtUsername, "Introduce un nombre de usuario.");
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblInfoRegister
            // 
            this.lblInfoRegister.AutoSize = true;
            this.lblInfoRegister.Location = new System.Drawing.Point(41, 310);
            this.lblInfoRegister.Name = "lblInfoRegister";
            this.lblInfoRegister.Size = new System.Drawing.Size(329, 23);
            this.lblInfoRegister.TabIndex = 3;
            this.lblInfoRegister.Text = "¿Todavía no tienes una cuenta?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(41, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(144, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "CONTRASEÑA";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USUARIO";
            // 
            // pibSpanish
            // 
            this.pibSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSpanish.Image = global::ProyectoGreenSpace.Properties.Resources.spain;
            this.pibSpanish.Location = new System.Drawing.Point(578, 33);
            this.pibSpanish.Name = "pibSpanish";
            this.pibSpanish.Size = new System.Drawing.Size(70, 60);
            this.pibSpanish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSpanish.TabIndex = 30;
            this.pibSpanish.TabStop = false;
            this.pibSpanish.Click += new System.EventHandler(this.pibSpanish_Click);
            // 
            // pibBritish
            // 
            this.pibBritish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibBritish.Image = global::ProyectoGreenSpace.Properties.Resources.united_kingdom;
            this.pibBritish.Location = new System.Drawing.Point(654, 33);
            this.pibBritish.Name = "pibBritish";
            this.pibBritish.Size = new System.Drawing.Size(70, 60);
            this.pibBritish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibBritish.TabIndex = 31;
            this.pibBritish.TabStop = false;
            this.pibBritish.Click += new System.EventHandler(this.pibBritish_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.pibBritish);
            this.Controls.Add(this.pibSpanish);
            this.Controls.Add(this.grpLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSpanish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBritish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblInfoRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lklblRegister;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lkllblRecoverPassword;
        private System.Windows.Forms.PictureBox pibSpanish;
        private System.Windows.Forms.PictureBox pibBritish;
    }
}
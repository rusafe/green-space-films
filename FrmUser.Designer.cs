namespace ProyectoGreenSpace
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.lblMailAssociated = new System.Windows.Forms.Label();
            this.pictBoxPhotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictBoxIcono = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPhotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccount.Location = new System.Drawing.Point(12, 206);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(261, 74);
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
            this.btnAdmin.Location = new System.Drawing.Point(12, 122);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(261, 78);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin.";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(12, 36);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(261, 80);
            this.btnUser.TabIndex = 12;
            this.btnUser.Text = "Usuario";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.BackColor = System.Drawing.Color.White;
            this.btnChangeName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeName.Location = new System.Drawing.Point(553, 147);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(206, 53);
            this.btnChangeName.TabIndex = 39;
            this.btnChangeName.Text = "Cambiar nombre";
            this.btnChangeName.UseVisualStyleBackColor = false;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BackColor = System.Drawing.Color.White;
            this.btnChangePhoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePhoto.Location = new System.Drawing.Point(553, 227);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(206, 53);
            this.btnChangePhoto.TabIndex = 38;
            this.btnChangePhoto.Text = "Cambiar Foto";
            this.btnChangePhoto.UseVisualStyleBackColor = false;
            // 
            // lblMailAssociated
            // 
            this.lblMailAssociated.AutoSize = true;
            this.lblMailAssociated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailAssociated.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMailAssociated.Location = new System.Drawing.Point(260, 339);
            this.lblMailAssociated.Name = "lblMailAssociated";
            this.lblMailAssociated.Size = new System.Drawing.Size(297, 23);
            this.lblMailAssociated.TabIndex = 36;
            this.lblMailAssociated.Text = "Cuenta asociada de correo: ";
            // 
            // pictBoxPhotoPerfil
            // 
            this.pictBoxPhotoPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictBoxPhotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictBoxPhotoPerfil.Location = new System.Drawing.Point(332, 36);
            this.pictBoxPhotoPerfil.Name = "pictBoxPhotoPerfil";
            this.pictBoxPhotoPerfil.Size = new System.Drawing.Size(168, 244);
            this.pictBoxPhotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxPhotoPerfil.TabIndex = 35;
            this.pictBoxPhotoPerfil.TabStop = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePassword.Location = new System.Drawing.Point(399, 414);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(236, 53);
            this.btnChangePassword.TabIndex = 34;
            this.btnChangePassword.Text = "Cambiar Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNameUser.Location = new System.Drawing.Point(530, 36);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(203, 23);
            this.lblNameUser.TabIndex = 33;
            this.lblNameUser.Text = "Nombre de Usuario:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(612, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 53);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictBoxIcono
            // 
            this.pictBoxIcono.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxIcono.Image")));
            this.pictBoxIcono.Location = new System.Drawing.Point(27, 376);
            this.pictBoxIcono.Name = "pictBoxIcono";
            this.pictBoxIcono.Size = new System.Drawing.Size(207, 172);
            this.pictBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxIcono.TabIndex = 30;
            this.pictBoxIcono.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblName.Location = new System.Drawing.Point(549, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 23);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Nombre ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmail.Location = new System.Drawing.Point(425, 376);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(185, 23);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "email@email.com";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 576);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.lblMailAssociated);
            this.Controls.Add(this.pictBoxPhotoPerfil);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictBoxIcono);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPhotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.Label lblMailAssociated;
        private System.Windows.Forms.PictureBox pictBoxPhotoPerfil;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictBoxIcono;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
    }
}
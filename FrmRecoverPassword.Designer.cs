namespace ProyectoGreenSpace
{
    partial class FrmRecoverPassword
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
            this.grpRecover = new System.Windows.Forms.GroupBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.pibPassword = new System.Windows.Forms.PictureBox();
            this.grpRecover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecover
            // 
            this.grpRecover.Controls.Add(this.pibReturn);
            this.grpRecover.Controls.Add(this.pibPassword);
            this.grpRecover.Controls.Add(this.btnLink);
            this.grpRecover.Controls.Add(this.txtUsername);
            this.grpRecover.Controls.Add(this.rtbInformation);
            this.grpRecover.Location = new System.Drawing.Point(41, 28);
            this.grpRecover.Name = "grpRecover";
            this.grpRecover.Size = new System.Drawing.Size(413, 482);
            this.grpRecover.TabIndex = 0;
            this.grpRecover.TabStop = false;
            this.grpRecover.Paint += new System.Windows.Forms.PaintEventHandler(this.grpRecover_Paint);
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.Location = new System.Drawing.Point(106, 400);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(198, 40);
            this.btnLink.TabIndex = 3;
            this.btnLink.Text = "Enviar enlace";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(69, 353);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 32);
            this.txtUsername.TabIndex = 2;
            // 
            // rtbInformation
            // 
            this.rtbInformation.Enabled = false;
            this.rtbInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformation.Location = new System.Drawing.Point(39, 201);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.ReadOnly = true;
            this.rtbInformation.Size = new System.Drawing.Size(339, 115);
            this.rtbInformation.TabIndex = 1;
            this.rtbInformation.Text = "Introduce tú nombre de usuario, recibirás en tú correo electrónico una contraseña" +
    " nueva.";
            // 
            // pibReturn
            // 
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Image = global::ProyectoGreenSpace.Properties.Resources.back;
            this.pibReturn.Location = new System.Drawing.Point(39, 33);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(50, 50);
            this.pibReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibReturn.TabIndex = 5;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // pibPassword
            // 
            this.pibPassword.Image = global::ProyectoGreenSpace.Properties.Resources._lock;
            this.pibPassword.Location = new System.Drawing.Point(154, 69);
            this.pibPassword.Name = "pibPassword";
            this.pibPassword.Size = new System.Drawing.Size(111, 99);
            this.pibPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPassword.TabIndex = 4;
            this.pibPassword.TabStop = false;
            // 
            // FrmRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 553);
            this.Controls.Add(this.grpRecover);
            this.Name = "FrmRecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmRecoverPassword_Load);
            this.grpRecover.ResumeLayout(false);
            this.grpRecover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecover;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pibReturn;
        private System.Windows.Forms.PictureBox pibPassword;
    }
}
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
            this.grpRecover.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecover
            // 
            this.grpRecover.Controls.Add(this.btnLink);
            this.grpRecover.Controls.Add(this.txtUsername);
            this.grpRecover.Controls.Add(this.rtbInformation);
            this.grpRecover.Location = new System.Drawing.Point(41, 39);
            this.grpRecover.Name = "grpRecover";
            this.grpRecover.Size = new System.Drawing.Size(532, 482);
            this.grpRecover.TabIndex = 0;
            this.grpRecover.TabStop = false;
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.Location = new System.Drawing.Point(149, 315);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(198, 73);
            this.btnLink.TabIndex = 3;
            this.btnLink.Text = "Enviar enlace";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(89, 260);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(326, 32);
            this.txtUsername.TabIndex = 2;
            // 
            // rtbInformation
            // 
            this.rtbInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformation.Location = new System.Drawing.Point(89, 139);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(326, 102);
            this.rtbInformation.TabIndex = 1;
            this.rtbInformation.Text = "Introduce tú nombre de usuario, recibirás en tú correo electrónico una contraseña" +
    " nueva.";
            // 
            // FrmRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.grpRecover);
            this.Name = "FrmRecoverPassword";
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmRecoverPassword_Load);
            this.grpRecover.ResumeLayout(false);
            this.grpRecover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecover;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TextBox txtUsername;
    }
}
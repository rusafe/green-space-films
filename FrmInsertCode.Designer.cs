namespace ProyectoGreenSpace
{
    partial class FrmInsertCode
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
            this.btnSend = new System.Windows.Forms.Button();
            this.mtbDigit1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDigit2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDigit3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDigit4 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDigit5 = new System.Windows.Forms.MaskedTextBox();
            this.mtbDigit6 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(257, 237);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(228, 65);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar código de verificación";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // mtbDigit1
            // 
            this.mtbDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit1.Location = new System.Drawing.Point(93, 84);
            this.mtbDigit1.Name = "mtbDigit1";
            this.mtbDigit1.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit1.TabIndex = 0;
            this.mtbDigit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDigit2
            // 
            this.mtbDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit2.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit2.Location = new System.Drawing.Point(191, 84);
            this.mtbDigit2.Name = "mtbDigit2";
            this.mtbDigit2.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit2.TabIndex = 1;
            this.mtbDigit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDigit3
            // 
            this.mtbDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit3.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit3.Location = new System.Drawing.Point(288, 84);
            this.mtbDigit3.Name = "mtbDigit3";
            this.mtbDigit3.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit3.TabIndex = 2;
            this.mtbDigit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDigit4
            // 
            this.mtbDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit4.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit4.Location = new System.Drawing.Point(382, 84);
            this.mtbDigit4.Name = "mtbDigit4";
            this.mtbDigit4.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit4.TabIndex = 3;
            this.mtbDigit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDigit5
            // 
            this.mtbDigit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit5.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit5.Location = new System.Drawing.Point(478, 84);
            this.mtbDigit5.Name = "mtbDigit5";
            this.mtbDigit5.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit5.TabIndex = 4;
            this.mtbDigit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbDigit6
            // 
            this.mtbDigit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDigit6.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDigit6.Location = new System.Drawing.Point(577, 84);
            this.mtbDigit6.Name = "mtbDigit6";
            this.mtbDigit6.Size = new System.Drawing.Size(68, 104);
            this.mtbDigit6.TabIndex = 5;
            this.mtbDigit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmInsertCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 337);
            this.Controls.Add(this.mtbDigit6);
            this.Controls.Add(this.mtbDigit5);
            this.Controls.Add(this.mtbDigit4);
            this.Controls.Add(this.mtbDigit3);
            this.Controls.Add(this.mtbDigit2);
            this.Controls.Add(this.mtbDigit1);
            this.Controls.Add(this.btnSend);
            this.Name = "FrmInsertCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmInsertCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.MaskedTextBox mtbDigit1;
        private System.Windows.Forms.MaskedTextBox mtbDigit2;
        private System.Windows.Forms.MaskedTextBox mtbDigit3;
        private System.Windows.Forms.MaskedTextBox mtbDigit4;
        private System.Windows.Forms.MaskedTextBox mtbDigit5;
        private System.Windows.Forms.MaskedTextBox mtbDigit6;
    }
}
namespace ProyectoGreenSpace
{
    partial class FrmInsertSession
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
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.grpInsertSessions = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.lblHour = new System.Windows.Forms.Label();
            this.cmbRoomsFilms = new System.Windows.Forms.ComboBox();
            this.roomsFilms = new System.Windows.Forms.Label();
            this.cmbFilmsIds = new System.Windows.Forms.ComboBox();
            this.cmbFilms = new System.Windows.Forms.ComboBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnModifyFrm = new System.Windows.Forms.Button();
            this.btnDeleteFrm = new System.Windows.Forms.Button();
            this.btnInsertFrm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.grpInsertSessions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(51, 373);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowHeadersWidth = 51;
            this.dgvSessions.RowTemplate.Height = 24;
            this.dgvSessions.Size = new System.Drawing.Size(504, 287);
            this.dgvSessions.TabIndex = 0;
            // 
            // grpInsertSessions
            // 
            this.grpInsertSessions.Controls.Add(this.btnInsert);
            this.grpInsertSessions.Controls.Add(this.dtpHour);
            this.grpInsertSessions.Controls.Add(this.lblHour);
            this.grpInsertSessions.Controls.Add(this.cmbRoomsFilms);
            this.grpInsertSessions.Controls.Add(this.roomsFilms);
            this.grpInsertSessions.Controls.Add(this.cmbFilmsIds);
            this.grpInsertSessions.Controls.Add(this.cmbFilms);
            this.grpInsertSessions.Controls.Add(this.lblFilm);
            this.grpInsertSessions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInsertSessions.Location = new System.Drawing.Point(240, 48);
            this.grpInsertSessions.Name = "grpInsertSessions";
            this.grpInsertSessions.Size = new System.Drawing.Size(315, 296);
            this.grpInsertSessions.TabIndex = 2;
            this.grpInsertSessions.TabStop = false;
            this.grpInsertSessions.Text = "Insertar sesión";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(49, 238);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(208, 32);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(174, 176);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.ShowUpDown = true;
            this.dtpHour.Size = new System.Drawing.Size(110, 28);
            this.dtpHour.TabIndex = 27;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(155, 136);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(129, 21);
            this.lblHour.TabIndex = 26;
            this.lblHour.Text = "Hora de inicio:";
            // 
            // cmbRoomsFilms
            // 
            this.cmbRoomsFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomsFilms.FormattingEnabled = true;
            this.cmbRoomsFilms.Location = new System.Drawing.Point(19, 175);
            this.cmbRoomsFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomsFilms.Name = "cmbRoomsFilms";
            this.cmbRoomsFilms.Size = new System.Drawing.Size(108, 29);
            this.cmbRoomsFilms.TabIndex = 25;
            // 
            // roomsFilms
            // 
            this.roomsFilms.AutoSize = true;
            this.roomsFilms.Location = new System.Drawing.Point(17, 136);
            this.roomsFilms.Name = "roomsFilms";
            this.roomsFilms.Size = new System.Drawing.Size(57, 21);
            this.roomsFilms.TabIndex = 24;
            this.roomsFilms.Text = "Salas:";
            // 
            // cmbFilmsIds
            // 
            this.cmbFilmsIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmsIds.FormattingEnabled = true;
            this.cmbFilmsIds.Location = new System.Drawing.Point(17, 79);
            this.cmbFilmsIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmsIds.Name = "cmbFilmsIds";
            this.cmbFilmsIds.Size = new System.Drawing.Size(55, 29);
            this.cmbFilmsIds.TabIndex = 23;
            // 
            // cmbFilms
            // 
            this.cmbFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilms.FormattingEnabled = true;
            this.cmbFilms.Location = new System.Drawing.Point(97, 79);
            this.cmbFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilms.Name = "cmbFilms";
            this.cmbFilms.Size = new System.Drawing.Size(185, 29);
            this.cmbFilms.TabIndex = 22;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(15, 46);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(85, 21);
            this.lblFilm.TabIndex = 21;
            this.lblFilm.Text = "Películas:";
            // 
            // btnModifyFrm
            // 
            this.btnModifyFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyFrm.Location = new System.Drawing.Point(51, 120);
            this.btnModifyFrm.Name = "btnModifyFrm";
            this.btnModifyFrm.Size = new System.Drawing.Size(153, 58);
            this.btnModifyFrm.TabIndex = 18;
            this.btnModifyFrm.Text = "Acceso modificaciones";
            this.btnModifyFrm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFrm
            // 
            this.btnDeleteFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFrm.Location = new System.Drawing.Point(51, 184);
            this.btnDeleteFrm.Name = "btnDeleteFrm";
            this.btnDeleteFrm.Size = new System.Drawing.Size(153, 58);
            this.btnDeleteFrm.TabIndex = 19;
            this.btnDeleteFrm.Text = "Acceso eliminaciones";
            this.btnDeleteFrm.UseVisualStyleBackColor = true;
            this.btnDeleteFrm.Click += new System.EventHandler(this.btnDeleteFrm_Click);
            // 
            // btnInsertFrm
            // 
            this.btnInsertFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFrm.Location = new System.Drawing.Point(51, 57);
            this.btnInsertFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertFrm.Name = "btnInsertFrm";
            this.btnInsertFrm.Size = new System.Drawing.Size(153, 58);
            this.btnInsertFrm.TabIndex = 24;
            this.btnInsertFrm.Text = "Acceso inserciones";
            this.btnInsertFrm.UseVisualStyleBackColor = true;
            this.btnInsertFrm.Click += new System.EventHandler(this.btnInsertFrm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 54);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmInsertSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnDeleteFrm);
            this.Controls.Add(this.btnModifyFrm);
            this.Controls.Add(this.grpInsertSessions);
            this.Controls.Add(this.dgvSessions);
            this.Name = "FrmInsertSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmInsertSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.grpInsertSessions.ResumeLayout(false);
            this.grpInsertSessions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.GroupBox grpInsertSessions;
        private System.Windows.Forms.Button btnModifyFrm;
        private System.Windows.Forms.Button btnDeleteFrm;
        private System.Windows.Forms.Button btnInsertFrm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbRoomsFilms;
        private System.Windows.Forms.Label roomsFilms;
        private System.Windows.Forms.ComboBox cmbFilmsIds;
        private System.Windows.Forms.ComboBox cmbFilms;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnInsert;
    }
}
namespace ProyectoGreenSpace
{
    partial class FrmMovieDelete
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
            this.btnModifyFrm = new System.Windows.Forms.Button();
            this.btnInsertFrm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.grpClock = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.cmbFilmsIds = new System.Windows.Forms.ComboBox();
            this.cmbFilms = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.pibImage = new System.Windows.Forms.PictureBox();
            this.rtbSynopsis = new System.Windows.Forms.RichTextBox();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            this.lblMinAge1 = new System.Windows.Forms.Label();
            this.lblGenre1 = new System.Windows.Forms.Label();
            this.lblGenre2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblDuration1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.grpClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyFrm
            // 
            this.btnModifyFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyFrm.Location = new System.Drawing.Point(803, 36);
            this.btnModifyFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyFrm.Name = "btnModifyFrm";
            this.btnModifyFrm.Size = new System.Drawing.Size(152, 70);
            this.btnModifyFrm.TabIndex = 4;
            this.btnModifyFrm.Text = "Acceso modificaciones";
            this.btnModifyFrm.UseVisualStyleBackColor = true;
            this.btnModifyFrm.Click += new System.EventHandler(this.btnModifyFrm_Click);
            // 
            // btnInsertFrm
            // 
            this.btnInsertFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFrm.Location = new System.Drawing.Point(625, 36);
            this.btnInsertFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertFrm.Name = "btnInsertFrm";
            this.btnInsertFrm.Size = new System.Drawing.Size(160, 70);
            this.btnInsertFrm.TabIndex = 3;
            this.btnInsertFrm.Text = "Acceso inserciones";
            this.btnInsertFrm.UseVisualStyleBackColor = true;
            this.btnInsertFrm.Click += new System.EventHandler(this.btnInsertFrm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1410, 473);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(625, 162);
            this.dgvFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(929, 300);
            this.dgvFilms.TabIndex = 27;
            // 
            // grpClock
            // 
            this.grpClock.Controls.Add(this.pictureBox1);
            this.grpClock.Controls.Add(this.lblClock);
            this.grpClock.Controls.Add(this.lblDate);
            this.grpClock.Location = new System.Drawing.Point(1163, 43);
            this.grpClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClock.Name = "grpClock";
            this.grpClock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClock.Size = new System.Drawing.Size(389, 100);
            this.grpClock.TabIndex = 26;
            this.grpClock.TabStop = false;
            this.grpClock.Paint += new System.Windows.Forms.PaintEventHandler(this.grpClock_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoGreenSpace.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(16, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(85, 41);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(82, 27);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(224, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label4";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.lblDuration1);
            this.grpDelete.Controls.Add(this.lblPrice1);
            this.grpDelete.Controls.Add(this.lblGenre2);
            this.grpDelete.Controls.Add(this.lblGenre1);
            this.grpDelete.Controls.Add(this.lblMinAge1);
            this.grpDelete.Controls.Add(this.cmbFilmsIds);
            this.grpDelete.Controls.Add(this.cmbFilms);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.lblGenre);
            this.grpDelete.Controls.Add(this.lblPrice);
            this.grpDelete.Controls.Add(this.lblMinAge);
            this.grpDelete.Controls.Add(this.lblDuration);
            this.grpDelete.Controls.Add(this.pibImage);
            this.grpDelete.Controls.Add(this.rtbSynopsis);
            this.grpDelete.Controls.Add(this.lblSynopsis);
            this.grpDelete.Controls.Add(this.lblFilm);
            this.grpDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelete.Location = new System.Drawing.Point(33, 36);
            this.grpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDelete.Size = new System.Drawing.Size(544, 476);
            this.grpDelete.TabIndex = 0;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "ELIMINAR PELÍCULAS";
            this.grpDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.grpDelete_Paint);
            // 
            // cmbFilmsIds
            // 
            this.cmbFilmsIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmsIds.FormattingEnabled = true;
            this.cmbFilmsIds.Location = new System.Drawing.Point(29, 96);
            this.cmbFilmsIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmsIds.Name = "cmbFilmsIds";
            this.cmbFilmsIds.Size = new System.Drawing.Size(55, 29);
            this.cmbFilmsIds.TabIndex = 0;
            // 
            // cmbFilms
            // 
            this.cmbFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilms.FormattingEnabled = true;
            this.cmbFilms.Location = new System.Drawing.Point(109, 96);
            this.cmbFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilms.Name = "cmbFilms";
            this.cmbFilms.Size = new System.Drawing.Size(185, 29);
            this.cmbFilms.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 422);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(488, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(262, 369);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(85, 21);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Géneros:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 371);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Precio:";
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(222, 334);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(125, 21);
            this.lblMinAge.TabIndex = 8;
            this.lblMinAge.Text = "Años mínimos:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(27, 334);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(90, 21);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duración:";
            // 
            // pibImage
            // 
            this.pibImage.Location = new System.Drawing.Point(333, 63);
            this.pibImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(184, 246);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 5;
            this.pibImage.TabStop = false;
            this.pibImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pibImage_Paint);
            // 
            // rtbSynopsis
            // 
            this.rtbSynopsis.Enabled = false;
            this.rtbSynopsis.Location = new System.Drawing.Point(29, 183);
            this.rtbSynopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSynopsis.Name = "rtbSynopsis";
            this.rtbSynopsis.ReadOnly = true;
            this.rtbSynopsis.Size = new System.Drawing.Size(265, 126);
            this.rtbSynopsis.TabIndex = 3;
            this.rtbSynopsis.Text = "";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(27, 148);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(76, 21);
            this.lblSynopsis.TabIndex = 2;
            this.lblSynopsis.Text = "Sinopsis:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(27, 63);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(85, 21);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Películas:";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // ofdSelect
            // 
            this.ofdSelect.FileName = "ofdSeleccionar";
            // 
            // lblMinAge1
            // 
            this.lblMinAge1.AutoSize = true;
            this.lblMinAge1.Location = new System.Drawing.Point(356, 334);
            this.lblMinAge1.Name = "lblMinAge1";
            this.lblMinAge1.Size = new System.Drawing.Size(60, 21);
            this.lblMinAge1.TabIndex = 21;
            this.lblMinAge1.Text = "label1";
            // 
            // lblGenre1
            // 
            this.lblGenre1.AutoSize = true;
            this.lblGenre1.Location = new System.Drawing.Point(356, 369);
            this.lblGenre1.Name = "lblGenre1";
            this.lblGenre1.Size = new System.Drawing.Size(60, 21);
            this.lblGenre1.TabIndex = 22;
            this.lblGenre1.Text = "label1";
            // 
            // lblGenre2
            // 
            this.lblGenre2.AutoSize = true;
            this.lblGenre2.Location = new System.Drawing.Point(441, 369);
            this.lblGenre2.Name = "lblGenre2";
            this.lblGenre2.Size = new System.Drawing.Size(60, 21);
            this.lblGenre2.TabIndex = 23;
            this.lblGenre2.Text = "label2";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(126, 371);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(51, 21);
            this.lblPrice1.TabIndex = 24;
            this.lblPrice1.Text = "label";
            // 
            // lblDuration1
            // 
            this.lblDuration1.AutoSize = true;
            this.lblDuration1.Location = new System.Drawing.Point(126, 334);
            this.lblDuration1.Name = "lblDuration1";
            this.lblDuration1.Size = new System.Drawing.Size(60, 21);
            this.lblDuration1.TabIndex = 25;
            this.lblDuration1.Text = "label1";
            // 
            // FrmMovieDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 540);
            this.Controls.Add(this.btnModifyFrm);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.grpClock);
            this.Controls.Add(this.grpDelete);
            this.Name = "FrmMovieDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmMovieDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.grpClock.ResumeLayout(false);
            this.grpClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifyFrm;
        private System.Windows.Forms.Button btnInsertFrm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.GroupBox grpClock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.ComboBox cmbFilmsIds;
        private System.Windows.Forms.ComboBox cmbFilms;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.RichTextBox rtbSynopsis;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        private System.Windows.Forms.Label lblDuration1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblGenre2;
        private System.Windows.Forms.Label lblGenre1;
        private System.Windows.Forms.Label lblMinAge1;
    }
}
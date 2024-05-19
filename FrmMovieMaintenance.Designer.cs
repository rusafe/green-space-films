namespace ProyectoGreenSpace
{
    partial class FrmMovieMaintenance
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbGenre2 = new System.Windows.Forms.ComboBox();
            this.chbNextPremiering = new System.Windows.Forms.CheckBox();
            this.chbPremiering = new System.Windows.Forms.CheckBox();
            this.cmbGenre1 = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudMinAge = new System.Windows.Forms.NumericUpDown();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.pibImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.rtbSynopsis = new System.Windows.Forms.RichTextBox();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpClock = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnModifyFrm = new System.Windows.Forms.Button();
            this.btnDeleteFrm = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            this.grpClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnInsert);
            this.grpMaintenance.Controls.Add(this.cmbGenre2);
            this.grpMaintenance.Controls.Add(this.chbNextPremiering);
            this.grpMaintenance.Controls.Add(this.chbPremiering);
            this.grpMaintenance.Controls.Add(this.cmbGenre1);
            this.grpMaintenance.Controls.Add(this.lblGenre);
            this.grpMaintenance.Controls.Add(this.txtPrice);
            this.grpMaintenance.Controls.Add(this.lblPrice);
            this.grpMaintenance.Controls.Add(this.nudMinAge);
            this.grpMaintenance.Controls.Add(this.lblMinAge);
            this.grpMaintenance.Controls.Add(this.txtDuration);
            this.grpMaintenance.Controls.Add(this.lblDuration);
            this.grpMaintenance.Controls.Add(this.pibImage);
            this.grpMaintenance.Controls.Add(this.btnUpload);
            this.grpMaintenance.Controls.Add(this.rtbSynopsis);
            this.grpMaintenance.Controls.Add(this.lblSynopsis);
            this.grpMaintenance.Controls.Add(this.txtFilm);
            this.grpMaintenance.Controls.Add(this.lblFilm);
            this.grpMaintenance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaintenance.Location = new System.Drawing.Point(28, 29);
            this.grpMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.grpMaintenance.Size = new System.Drawing.Size(446, 579);
            this.grpMaintenance.TabIndex = 1;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "INSERTAR PELÍCULAS";
            this.grpMaintenance.Paint += new System.Windows.Forms.PaintEventHandler(this.grpMaintenance_Paint);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(22, 531);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(394, 32);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbGenre2
            // 
            this.cmbGenre2.FormattingEnabled = true;
            this.cmbGenre2.Items.AddRange(new object[] {
            "Accion",
            "Aventura",
            "Misterio",
            "Ciencia Ficción",
            "Drama",
            "Fantasía",
            "Terror",
            "Suspense",
            "Comedia"});
            this.cmbGenre2.Location = new System.Drawing.Point(314, 463);
            this.cmbGenre2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre2.Name = "cmbGenre2";
            this.cmbGenre2.Size = new System.Drawing.Size(102, 29);
            this.cmbGenre2.TabIndex = 17;
            // 
            // chbNextPremiering
            // 
            this.chbNextPremiering.AutoSize = true;
            this.chbNextPremiering.Location = new System.Drawing.Point(30, 494);
            this.chbNextPremiering.Margin = new System.Windows.Forms.Padding(2);
            this.chbNextPremiering.Name = "chbNextPremiering";
            this.chbNextPremiering.Size = new System.Drawing.Size(160, 25);
            this.chbNextPremiering.TabIndex = 16;
            this.chbNextPremiering.Text = "Proximo Estreno";
            this.chbNextPremiering.UseVisualStyleBackColor = true;
            // 
            // chbPremiering
            // 
            this.chbPremiering.AutoSize = true;
            this.chbPremiering.Location = new System.Drawing.Point(30, 467);
            this.chbPremiering.Margin = new System.Windows.Forms.Padding(2);
            this.chbPremiering.Name = "chbPremiering";
            this.chbPremiering.Size = new System.Drawing.Size(190, 25);
            this.chbPremiering.TabIndex = 15;
            this.chbPremiering.Text = "Estreno de película";
            this.chbPremiering.UseVisualStyleBackColor = true;
            // 
            // cmbGenre1
            // 
            this.cmbGenre1.FormattingEnabled = true;
            this.cmbGenre1.Items.AddRange(new object[] {
            "Accion",
            "Aventura",
            "Misterio",
            "Ciencia Ficción",
            "Drama",
            "Fantasía",
            "Terror",
            "Suspense",
            "Comedia"});
            this.cmbGenre1.Location = new System.Drawing.Point(314, 416);
            this.cmbGenre1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre1.Name = "cmbGenre1";
            this.cmbGenre1.Size = new System.Drawing.Size(102, 29);
            this.cmbGenre1.TabIndex = 13;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(269, 382);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(85, 21);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Géneros:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(30, 415);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 28);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(26, 382);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Precio:";
            // 
            // nudMinAge
            // 
            this.nudMinAge.Location = new System.Drawing.Point(346, 330);
            this.nudMinAge.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinAge.Name = "nudMinAge";
            this.nudMinAge.Size = new System.Drawing.Size(69, 28);
            this.nudMinAge.TabIndex = 9;
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(269, 295);
            this.lblMinAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(125, 21);
            this.lblMinAge.TabIndex = 8;
            this.lblMinAge.Text = "Años mínimos:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(30, 329);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(205, 28);
            this.txtDuration.TabIndex = 7;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(26, 295);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(90, 21);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duración:";
            // 
            // pibImage
            // 
            this.pibImage.Location = new System.Drawing.Point(272, 46);
            this.pibImage.Margin = new System.Windows.Forms.Padding(2);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(142, 162);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 5;
            this.pibImage.TabStop = false;
            this.pibImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pibImage_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(272, 226);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 51);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Cargar imagen";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rtbSynopsis
            // 
            this.rtbSynopsis.Location = new System.Drawing.Point(30, 166);
            this.rtbSynopsis.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSynopsis.Name = "rtbSynopsis";
            this.rtbSynopsis.Size = new System.Drawing.Size(205, 111);
            this.rtbSynopsis.TabIndex = 3;
            this.rtbSynopsis.Text = "";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(26, 131);
            this.lblSynopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(76, 21);
            this.lblSynopsis.TabIndex = 2;
            this.lblSynopsis.Text = "Sinopsis:";
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(30, 80);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(205, 28);
            this.txtFilm.TabIndex = 1;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(26, 46);
            this.lblFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(78, 21);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Película:";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(70, 41);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(82, 27);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(156, 41);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label4";
            // 
            // grpClock
            // 
            this.grpClock.Controls.Add(this.pictureBox1);
            this.grpClock.Controls.Add(this.lblClock);
            this.grpClock.Controls.Add(this.lblDate);
            this.grpClock.Location = new System.Drawing.Point(1075, 46);
            this.grpClock.Margin = new System.Windows.Forms.Padding(2);
            this.grpClock.Name = "grpClock";
            this.grpClock.Padding = new System.Windows.Forms.Padding(2);
            this.grpClock.Size = new System.Drawing.Size(279, 91);
            this.grpClock.TabIndex = 4;
            this.grpClock.TabStop = false;
            this.grpClock.Paint += new System.Windows.Forms.PaintEventHandler(this.grpClock_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoGreenSpace.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(16, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(511, 210);
            this.dgvFilms.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(843, 336);
            this.dgvFilms.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(1210, 569);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 39);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // ofdSelect
            // 
            this.ofdSelect.FileName = "ofdSeleccionar";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnModifyFrm
            // 
            this.btnModifyFrm.Location = new System.Drawing.Point(511, 44);
            this.btnModifyFrm.Name = "btnModifyFrm";
            this.btnModifyFrm.Size = new System.Drawing.Size(168, 52);
            this.btnModifyFrm.TabIndex = 17;
            this.btnModifyFrm.Text = "Acceso modficaciones";
            this.btnModifyFrm.UseVisualStyleBackColor = true;
            this.btnModifyFrm.Click += new System.EventHandler(this.btnModifyFrm_Click);
            // 
            // btnDeleteFrm
            // 
            this.btnDeleteFrm.Location = new System.Drawing.Point(700, 44);
            this.btnDeleteFrm.Name = "btnDeleteFrm";
            this.btnDeleteFrm.Size = new System.Drawing.Size(168, 52);
            this.btnDeleteFrm.TabIndex = 18;
            this.btnDeleteFrm.Text = "Acceso eliminaciones";
            this.btnDeleteFrm.UseVisualStyleBackColor = true;
            this.btnDeleteFrm.Click += new System.EventHandler(this.btnDeleteFrm_Click);
            // 
            // FrmMovieMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 657);
            this.Controls.Add(this.btnDeleteFrm);
            this.Controls.Add(this.btnModifyFrm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.grpClock);
            this.Controls.Add(this.grpMaintenance);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMovieMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmMovieMaintenance_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            this.grpClock.ResumeLayout(false);
            this.grpClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.RichTextBox rtbSynopsis;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NumericUpDown nudMinAge;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.CheckBox chbPremiering;
        private System.Windows.Forms.ComboBox cmbGenre1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpClock;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        private System.Windows.Forms.CheckBox chbNextPremiering;
        private System.Windows.Forms.ComboBox cmbGenre2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModifyFrm;
        private System.Windows.Forms.Button btnDeleteFrm;
    }
}
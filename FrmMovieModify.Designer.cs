namespace ProyectoGreenSpace
{
    partial class FrmMovieModify
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
            this.btnDeleteFrm = new System.Windows.Forms.Button();
            this.btnInsertFrm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.grpClock = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.cmbFilmsIds = new System.Windows.Forms.ComboBox();
            this.cmbFilms = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
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
            this.lblFilm = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.grpClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteFrm
            // 
            this.btnDeleteFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFrm.Location = new System.Drawing.Point(598, 37);
            this.btnDeleteFrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFrm.Name = "btnDeleteFrm";
            this.btnDeleteFrm.Size = new System.Drawing.Size(114, 57);
            this.btnDeleteFrm.TabIndex = 24;
            this.btnDeleteFrm.Text = "Acceso eliminaciones";
            this.btnDeleteFrm.UseVisualStyleBackColor = true;
            this.btnDeleteFrm.Click += new System.EventHandler(this.btnDeleteFrm_Click);
            // 
            // btnInsertFrm
            // 
            this.btnInsertFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFrm.Location = new System.Drawing.Point(464, 37);
            this.btnInsertFrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertFrm.Name = "btnInsertFrm";
            this.btnInsertFrm.Size = new System.Drawing.Size(120, 57);
            this.btnInsertFrm.TabIndex = 23;
            this.btnInsertFrm.Text = "Acceso inserciones";
            this.btnInsertFrm.UseVisualStyleBackColor = true;
            this.btnInsertFrm.Click += new System.EventHandler(this.btnInsertFrm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1053, 505);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 32);
            this.btnBack.TabIndex = 22;
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
            this.dgvFilms.Location = new System.Drawing.Point(464, 180);
            this.dgvFilms.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(697, 299);
            this.dgvFilms.TabIndex = 21;
            // 
            // grpClock
            // 
            this.grpClock.Controls.Add(this.pictureBox1);
            this.grpClock.Controls.Add(this.lblClock);
            this.grpClock.Controls.Add(this.lblDate);
            this.grpClock.Location = new System.Drawing.Point(868, 43);
            this.grpClock.Margin = new System.Windows.Forms.Padding(2);
            this.grpClock.Name = "grpClock";
            this.grpClock.Padding = new System.Windows.Forms.Padding(2);
            this.grpClock.Size = new System.Drawing.Size(292, 81);
            this.grpClock.TabIndex = 20;
            this.grpClock.TabStop = false;
            this.grpClock.Paint += new System.Windows.Forms.PaintEventHandler(this.grpClock_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoGreenSpace.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(64, 33);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(69, 23);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(168, 33);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label4";
            // 
            // grpModify
            // 
            this.grpModify.Controls.Add(this.cmbFilmsIds);
            this.grpModify.Controls.Add(this.cmbFilms);
            this.grpModify.Controls.Add(this.btnModify);
            this.grpModify.Controls.Add(this.cmbGenre2);
            this.grpModify.Controls.Add(this.chbNextPremiering);
            this.grpModify.Controls.Add(this.chbPremiering);
            this.grpModify.Controls.Add(this.cmbGenre1);
            this.grpModify.Controls.Add(this.lblGenre);
            this.grpModify.Controls.Add(this.txtPrice);
            this.grpModify.Controls.Add(this.lblPrice);
            this.grpModify.Controls.Add(this.nudMinAge);
            this.grpModify.Controls.Add(this.lblMinAge);
            this.grpModify.Controls.Add(this.txtDuration);
            this.grpModify.Controls.Add(this.lblDuration);
            this.grpModify.Controls.Add(this.pibImage);
            this.grpModify.Controls.Add(this.btnUpload);
            this.grpModify.Controls.Add(this.rtbSynopsis);
            this.grpModify.Controls.Add(this.lblSynopsis);
            this.grpModify.Controls.Add(this.lblFilm);
            this.grpModify.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModify.Location = new System.Drawing.Point(20, 37);
            this.grpModify.Margin = new System.Windows.Forms.Padding(2);
            this.grpModify.Name = "grpModify";
            this.grpModify.Padding = new System.Windows.Forms.Padding(2);
            this.grpModify.Size = new System.Drawing.Size(408, 523);
            this.grpModify.TabIndex = 19;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "MODIFICAR PELÍCULAS";
            this.grpModify.Paint += new System.Windows.Forms.PaintEventHandler(this.grpModify_Paint);
            // 
            // cmbFilmsIds
            // 
            this.cmbFilmsIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmsIds.FormattingEnabled = true;
            this.cmbFilmsIds.Location = new System.Drawing.Point(22, 78);
            this.cmbFilmsIds.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilmsIds.Name = "cmbFilmsIds";
            this.cmbFilmsIds.Size = new System.Drawing.Size(42, 27);
            this.cmbFilmsIds.TabIndex = 20;
            this.cmbFilmsIds.SelectedValueChanged += new System.EventHandler(this.cmbFilmsIds_SelectedValueChanged);
            // 
            // cmbFilms
            // 
            this.cmbFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilms.FormattingEnabled = true;
            this.cmbFilms.Location = new System.Drawing.Point(82, 78);
            this.cmbFilms.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilms.Name = "cmbFilms";
            this.cmbFilms.Size = new System.Drawing.Size(140, 27);
            this.cmbFilms.TabIndex = 19;
            this.cmbFilms.SelectedValueChanged += new System.EventHandler(this.cmbFilms_SelectedValueChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(22, 483);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(344, 26);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Actualizar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
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
            this.cmbGenre2.Location = new System.Drawing.Point(282, 417);
            this.cmbGenre2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre2.Name = "cmbGenre2";
            this.cmbGenre2.Size = new System.Drawing.Size(86, 27);
            this.cmbGenre2.TabIndex = 17;
            // 
            // chbNextPremiering
            // 
            this.chbNextPremiering.AutoSize = true;
            this.chbNextPremiering.Location = new System.Drawing.Point(22, 436);
            this.chbNextPremiering.Margin = new System.Windows.Forms.Padding(2);
            this.chbNextPremiering.Name = "chbNextPremiering";
            this.chbNextPremiering.Size = new System.Drawing.Size(134, 23);
            this.chbNextPremiering.TabIndex = 16;
            this.chbNextPremiering.Text = "Proximo Estreno";
            this.chbNextPremiering.UseVisualStyleBackColor = true;
            // 
            // chbPremiering
            // 
            this.chbPremiering.AutoSize = true;
            this.chbPremiering.Location = new System.Drawing.Point(22, 414);
            this.chbPremiering.Margin = new System.Windows.Forms.Padding(2);
            this.chbPremiering.Name = "chbPremiering";
            this.chbPremiering.Size = new System.Drawing.Size(160, 23);
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
            this.cmbGenre1.Location = new System.Drawing.Point(282, 379);
            this.cmbGenre1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre1.Name = "cmbGenre1";
            this.cmbGenre1.Size = new System.Drawing.Size(86, 27);
            this.cmbGenre1.TabIndex = 13;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(248, 351);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(70, 19);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Géneros:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(22, 378);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 24);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 351);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 19);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Precio:";
            // 
            // nudMinAge
            // 
            this.nudMinAge.Location = new System.Drawing.Point(306, 300);
            this.nudMinAge.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinAge.Name = "nudMinAge";
            this.nudMinAge.Size = new System.Drawing.Size(61, 24);
            this.nudMinAge.TabIndex = 9;
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(248, 271);
            this.lblMinAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(104, 19);
            this.lblMinAge.TabIndex = 8;
            this.lblMinAge.Text = "Años mínimos:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(22, 299);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 24);
            this.txtDuration.TabIndex = 7;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 271);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(76, 19);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duración:";
            // 
            // pibImage
            // 
            this.pibImage.Location = new System.Drawing.Point(250, 51);
            this.pibImage.Margin = new System.Windows.Forms.Padding(2);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(138, 144);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 5;
            this.pibImage.TabStop = false;
            this.pibImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pibImage_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(250, 210);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 41);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Cargar imagen";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rtbSynopsis
            // 
            this.rtbSynopsis.Location = new System.Drawing.Point(22, 149);
            this.rtbSynopsis.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSynopsis.Name = "rtbSynopsis";
            this.rtbSynopsis.Size = new System.Drawing.Size(200, 103);
            this.rtbSynopsis.TabIndex = 3;
            this.rtbSynopsis.Text = "";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(20, 120);
            this.lblSynopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(64, 19);
            this.lblSynopsis.TabIndex = 2;
            this.lblSynopsis.Text = "Sinopsis:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(20, 51);
            this.lblFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(72, 19);
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
            // FrmMovieModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 582);
            this.Controls.Add(this.btnDeleteFrm);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.grpClock);
            this.Controls.Add(this.grpModify);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMovieModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovieModify";
            this.Load += new System.EventHandler(this.FrmMovieModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.grpClock.ResumeLayout(false);
            this.grpClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpModify.ResumeLayout(false);
            this.grpModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteFrm;
        private System.Windows.Forms.Button btnInsertFrm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.GroupBox grpClock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox cmbGenre2;
        private System.Windows.Forms.CheckBox chbNextPremiering;
        private System.Windows.Forms.CheckBox chbPremiering;
        private System.Windows.Forms.ComboBox cmbGenre1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudMinAge;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RichTextBox rtbSynopsis;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        private System.Windows.Forms.ComboBox cmbFilms;
        private System.Windows.Forms.ComboBox cmbFilmsIds;
    }
}
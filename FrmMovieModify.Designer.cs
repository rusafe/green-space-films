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
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInsertSessions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.grpClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteFrm
            // 
            this.btnDeleteFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFrm.Location = new System.Drawing.Point(797, 46);
            this.btnDeleteFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFrm.Name = "btnDeleteFrm";
            this.btnDeleteFrm.Size = new System.Drawing.Size(152, 70);
            this.btnDeleteFrm.TabIndex = 24;
            this.btnDeleteFrm.Text = "Acceso eliminaciones";
            this.btnDeleteFrm.UseVisualStyleBackColor = true;
            this.btnDeleteFrm.Click += new System.EventHandler(this.btnDeleteFrm_Click);
            // 
            // btnInsertFrm
            // 
            this.btnInsertFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFrm.Location = new System.Drawing.Point(619, 46);
            this.btnInsertFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertFrm.Name = "btnInsertFrm";
            this.btnInsertFrm.Size = new System.Drawing.Size(160, 70);
            this.btnInsertFrm.TabIndex = 23;
            this.btnInsertFrm.Text = "Acceso inserciones";
            this.btnInsertFrm.UseVisualStyleBackColor = true;
            this.btnInsertFrm.Click += new System.EventHandler(this.btnInsertFrm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1404, 651);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 39);
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
            this.dgvFilms.Location = new System.Drawing.Point(619, 222);
            this.dgvFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(929, 406);
            this.dgvFilms.TabIndex = 21;
            // 
            // grpClock
            // 
            this.grpClock.Controls.Add(this.pictureBox1);
            this.grpClock.Controls.Add(this.lblClock);
            this.grpClock.Controls.Add(this.lblDate);
            this.grpClock.Location = new System.Drawing.Point(1157, 53);
            this.grpClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClock.Name = "grpClock";
            this.grpClock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClock.Size = new System.Drawing.Size(389, 100);
            this.grpClock.TabIndex = 20;
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
            this.grpModify.Location = new System.Drawing.Point(27, 46);
            this.grpModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModify.Name = "grpModify";
            this.grpModify.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModify.Size = new System.Drawing.Size(544, 644);
            this.grpModify.TabIndex = 19;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "MODIFICAR PELÍCULAS";
            this.grpModify.Paint += new System.Windows.Forms.PaintEventHandler(this.grpModify_Paint);
            // 
            // cmbFilmsIds
            // 
            this.cmbFilmsIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmsIds.FormattingEnabled = true;
            this.cmbFilmsIds.Location = new System.Drawing.Point(29, 96);
            this.cmbFilmsIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmsIds.Name = "cmbFilmsIds";
            this.cmbFilmsIds.Size = new System.Drawing.Size(55, 29);
            this.cmbFilmsIds.TabIndex = 20;
            this.cmbFilmsIds.SelectedValueChanged += new System.EventHandler(this.cmbFilmsIds_SelectedValueChanged);
            // 
            // cmbFilms
            // 
            this.cmbFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilms.FormattingEnabled = true;
            this.cmbFilms.Location = new System.Drawing.Point(109, 96);
            this.cmbFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilms.Name = "cmbFilms";
            this.cmbFilms.Size = new System.Drawing.Size(185, 29);
            this.cmbFilms.TabIndex = 19;
            this.cmbFilms.SelectedValueChanged += new System.EventHandler(this.cmbFilms_SelectedValueChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(29, 594);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(459, 32);
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
            this.cmbGenre2.Location = new System.Drawing.Point(376, 513);
            this.cmbGenre2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre2.Name = "cmbGenre2";
            this.cmbGenre2.Size = new System.Drawing.Size(113, 29);
            this.cmbGenre2.TabIndex = 17;
            // 
            // chbNextPremiering
            // 
            this.chbNextPremiering.AutoSize = true;
            this.chbNextPremiering.Location = new System.Drawing.Point(29, 537);
            this.chbNextPremiering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbNextPremiering.Name = "chbNextPremiering";
            this.chbNextPremiering.Size = new System.Drawing.Size(160, 25);
            this.chbNextPremiering.TabIndex = 16;
            this.chbNextPremiering.Text = "Proximo Estreno";
            this.chbNextPremiering.UseVisualStyleBackColor = true;
            // 
            // chbPremiering
            // 
            this.chbPremiering.AutoSize = true;
            this.chbPremiering.Location = new System.Drawing.Point(29, 510);
            this.chbPremiering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cmbGenre1.Location = new System.Drawing.Point(376, 466);
            this.cmbGenre1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre1.Name = "cmbGenre1";
            this.cmbGenre1.Size = new System.Drawing.Size(113, 29);
            this.cmbGenre1.TabIndex = 13;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(331, 432);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(85, 21);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Géneros:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(29, 465);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(265, 28);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 432);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Precio:";
            // 
            // nudMinAge
            // 
            this.nudMinAge.Location = new System.Drawing.Point(408, 369);
            this.nudMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMinAge.Name = "nudMinAge";
            this.nudMinAge.Size = new System.Drawing.Size(81, 28);
            this.nudMinAge.TabIndex = 9;
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(331, 334);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(125, 21);
            this.lblMinAge.TabIndex = 8;
            this.lblMinAge.Text = "Años mínimos:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(29, 368);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(265, 28);
            this.txtDuration.TabIndex = 7;
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
            this.pibImage.Size = new System.Drawing.Size(184, 177);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 5;
            this.pibImage.TabStop = false;
            this.pibImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pibImage_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(333, 258);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(184, 50);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Cargar imagen";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rtbSynopsis
            // 
            this.rtbSynopsis.Location = new System.Drawing.Point(29, 183);
            this.rtbSynopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSynopsis.Name = "rtbSynopsis";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1558, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "        ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnInsertSessions
            // 
            this.btnInsertSessions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSessions.Location = new System.Drawing.Point(966, 46);
            this.btnInsertSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertSessions.Name = "btnInsertSessions";
            this.btnInsertSessions.Size = new System.Drawing.Size(152, 70);
            this.btnInsertSessions.TabIndex = 29;
            this.btnInsertSessions.Text = "Acceso sesiones";
            this.btnInsertSessions.UseVisualStyleBackColor = true;
            this.btnInsertSessions.Click += new System.EventHandler(this.btnInsertSessions_Click);
            // 
            // FrmMovieModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 716);
            this.Controls.Add(this.btnInsertSessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteFrm);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.grpClock);
            this.Controls.Add(this.grpModify);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnInsertSessions;
    }
}
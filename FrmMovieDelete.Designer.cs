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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovieDelete));
            this.btnModifyFrm = new System.Windows.Forms.Button();
            this.btnInsertFrm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.grpClock = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.lblDuration1 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblGenre2 = new System.Windows.Forms.Label();
            this.lblGenre1 = new System.Windows.Forms.Label();
            this.lblMinAge1 = new System.Windows.Forms.Label();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInsertSessions = new System.Windows.Forms.Button();
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pibMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.grpClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.g2Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyFrm
            // 
            this.btnModifyFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyFrm.Location = new System.Drawing.Point(800, 89);
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
            this.btnInsertFrm.Location = new System.Drawing.Point(621, 89);
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
            this.btnBack.Location = new System.Drawing.Point(1407, 526);
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
            this.dgvFilms.Location = new System.Drawing.Point(621, 214);
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
            this.grpClock.Location = new System.Drawing.Point(1160, 95);
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
            this.grpDelete.Location = new System.Drawing.Point(29, 89);
            this.grpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDelete.Size = new System.Drawing.Size(544, 476);
            this.grpDelete.TabIndex = 0;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "ELIMINAR PELÍCULAS";
            this.grpDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.grpDelete_Paint);
            // 
            // lblDuration1
            // 
            this.lblDuration1.AutoSize = true;
            this.lblDuration1.Location = new System.Drawing.Point(125, 334);
            this.lblDuration1.Name = "lblDuration1";
            this.lblDuration1.Size = new System.Drawing.Size(60, 21);
            this.lblDuration1.TabIndex = 25;
            this.lblDuration1.Text = "label1";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(125, 370);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(51, 21);
            this.lblPrice1.TabIndex = 24;
            this.lblPrice1.Text = "label";
            // 
            // lblGenre2
            // 
            this.lblGenre2.AutoSize = true;
            this.lblGenre2.Location = new System.Drawing.Point(356, 396);
            this.lblGenre2.Name = "lblGenre2";
            this.lblGenre2.Size = new System.Drawing.Size(60, 21);
            this.lblGenre2.TabIndex = 23;
            this.lblGenre2.Text = "label2";
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
            // lblMinAge1
            // 
            this.lblMinAge1.AutoSize = true;
            this.lblMinAge1.Location = new System.Drawing.Point(356, 334);
            this.lblMinAge1.Name = "lblMinAge1";
            this.lblMinAge1.Size = new System.Drawing.Size(60, 21);
            this.lblMinAge1.TabIndex = 21;
            this.lblMinAge1.Text = "label1";
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
            this.cmbFilms.TabIndex = 1;
            this.cmbFilms.SelectedValueChanged += new System.EventHandler(this.cmbFilms_SelectedValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 430);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(488, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(261, 369);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(85, 21);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Géneros:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 370);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Precio:";
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(221, 334);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnInsertSessions
            // 
            this.btnInsertSessions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSessions.Location = new System.Drawing.Point(967, 89);
            this.btnInsertSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertSessions.Name = "btnInsertSessions";
            this.btnInsertSessions.Size = new System.Drawing.Size(152, 70);
            this.btnInsertSessions.TabIndex = 28;
            this.btnInsertSessions.Text = "Acceso sesiones";
            this.btnInsertSessions.UseVisualStyleBackColor = true;
            this.btnInsertSessions.Click += new System.EventHandler(this.btnInsertSessions_Click);
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Controls.Add(this.pibMinimize);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibClose);
            this.g2Bar.Location = new System.Drawing.Point(-1, -1);
            this.g2Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(1588, 44);
            this.g2Bar.TabIndex = 49;
            // 
            // g2lblTitle
            // 
            this.g2lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.g2lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2lblTitle.Location = new System.Drawing.Point(13, 7);
            this.g2lblTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.g2lblTitle.Name = "g2lblTitle";
            this.g2lblTitle.Size = new System.Drawing.Size(194, 25);
            this.g2lblTitle.TabIndex = 36;
            this.g2lblTitle.Text = "GREEN SPACE FILMS";
            // 
            // pibMinimize
            // 
            this.pibMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pibMinimize.Image")));
            this.pibMinimize.ImageRotate = 0F;
            this.pibMinimize.Location = new System.Drawing.Point(1455, 7);
            this.pibMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibMinimize.Name = "pibMinimize";
            this.pibMinimize.Size = new System.Drawing.Size(35, 25);
            this.pibMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMinimize.TabIndex = 35;
            this.pibMinimize.TabStop = false;
            this.pibMinimize.Click += new System.EventHandler(this.pibMinimize_Click);
            // 
            // pibMaximize
            // 
            this.pibMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximize.Image = global::ProyectoGreenSpace.Properties.Resources.maximizar;
            this.pibMaximize.ImageRotate = 0F;
            this.pibMaximize.Location = new System.Drawing.Point(1497, 7);
            this.pibMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibMaximize.Name = "pibMaximize";
            this.pibMaximize.Size = new System.Drawing.Size(35, 25);
            this.pibMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMaximize.TabIndex = 34;
            this.pibMaximize.TabStop = false;
            this.pibMaximize.Click += new System.EventHandler(this.pibMaximize_Click);
            // 
            // pibClose
            // 
            this.pibClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Image = ((System.Drawing.Image)(resources.GetObject("pibClose.Image")));
            this.pibClose.ImageRotate = 0F;
            this.pibClose.Location = new System.Drawing.Point(1536, 2);
            this.pibClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(39, 33);
            this.pibClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibClose.TabIndex = 33;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.g2Bar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmMovieDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 608);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.btnInsertSessions);
            this.Controls.Add(this.btnModifyFrm);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.grpClock);
            this.Controls.Add(this.grpDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnInsertSessions;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pibMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
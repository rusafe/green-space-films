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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertSession));
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.grpInsertSessions = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.lblHour = new System.Windows.Forms.Label();
            this.cmbRoomsFilms = new System.Windows.Forms.ComboBox();
            this.lblRoomsFilms = new System.Windows.Forms.Label();
            this.cmbFilmsIds = new System.Windows.Forms.ComboBox();
            this.cmbFilms = new System.Windows.Forms.ComboBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnModifyFrm = new System.Windows.Forms.Button();
            this.btnDeleteFrm = new System.Windows.Forms.Button();
            this.btnInsertFrm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pibMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnResetSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.grpInsertSessions.SuspendLayout();
            this.g2Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(54, 398);
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
            this.grpInsertSessions.Controls.Add(this.lblRoomsFilms);
            this.grpInsertSessions.Controls.Add(this.cmbFilmsIds);
            this.grpInsertSessions.Controls.Add(this.cmbFilms);
            this.grpInsertSessions.Controls.Add(this.lblFilm);
            this.grpInsertSessions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInsertSessions.Location = new System.Drawing.Point(243, 73);
            this.grpInsertSessions.Name = "grpInsertSessions";
            this.grpInsertSessions.Size = new System.Drawing.Size(315, 296);
            this.grpInsertSessions.TabIndex = 2;
            this.grpInsertSessions.TabStop = false;
            this.grpInsertSessions.Text = "Insertar sesión";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(49, 238);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(208, 43);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(174, 176);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.ShowUpDown = true;
            this.dtpHour.Size = new System.Drawing.Size(110, 28);
            this.dtpHour.TabIndex = 27;
            this.dtpHour.Value = new System.DateTime(2024, 5, 25, 12, 0, 0, 0);
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
            // lblRoomsFilms
            // 
            this.lblRoomsFilms.AutoSize = true;
            this.lblRoomsFilms.Location = new System.Drawing.Point(17, 136);
            this.lblRoomsFilms.Name = "lblRoomsFilms";
            this.lblRoomsFilms.Size = new System.Drawing.Size(57, 21);
            this.lblRoomsFilms.TabIndex = 24;
            this.lblRoomsFilms.Text = "Salas:";
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
            this.cmbFilmsIds.SelectedValueChanged += new System.EventHandler(this.cmbFilmsIds_SelectedValueChanged);
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
            this.cmbFilms.SelectedValueChanged += new System.EventHandler(this.cmbFilms_SelectedValueChanged);
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
            this.btnModifyFrm.Location = new System.Drawing.Point(54, 145);
            this.btnModifyFrm.Name = "btnModifyFrm";
            this.btnModifyFrm.Size = new System.Drawing.Size(153, 58);
            this.btnModifyFrm.TabIndex = 18;
            this.btnModifyFrm.Text = "Acceso modificaciones";
            this.btnModifyFrm.UseVisualStyleBackColor = true;
            this.btnModifyFrm.Click += new System.EventHandler(this.btnModifyFrm_Click);
            // 
            // btnDeleteFrm
            // 
            this.btnDeleteFrm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFrm.Location = new System.Drawing.Point(54, 209);
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
            this.btnInsertFrm.Location = new System.Drawing.Point(54, 82);
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
            this.btnBack.Location = new System.Drawing.Point(54, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 54);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Controls.Add(this.pibMinimize);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibClose);
            this.g2Bar.Location = new System.Drawing.Point(-1, 0);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(607, 42);
            this.g2Bar.TabIndex = 49;
            // 
            // g2lblTitle
            // 
            this.g2lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.g2lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2lblTitle.Location = new System.Drawing.Point(13, 8);
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
            this.pibMinimize.Location = new System.Drawing.Point(474, 8);
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
            this.pibMaximize.Location = new System.Drawing.Point(516, 8);
            this.pibMaximize.Name = "pibMaximize";
            this.pibMaximize.Size = new System.Drawing.Size(34, 25);
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
            this.pibClose.Location = new System.Drawing.Point(555, 3);
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
            // btnResetSession
            // 
            this.btnResetSession.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSession.Location = new System.Drawing.Point(359, 700);
            this.btnResetSession.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSession.Name = "btnResetSession";
            this.btnResetSession.Size = new System.Drawing.Size(199, 50);
            this.btnResetSession.TabIndex = 50;
            this.btnResetSession.Text = "Reiniciar sesión";
            this.btnResetSession.UseVisualStyleBackColor = true;
            this.btnResetSession.Click += new System.EventHandler(this.btnResetSession_Click);
            // 
            // FrmInsertSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 775);
            this.Controls.Add(this.btnResetSession);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsertFrm);
            this.Controls.Add(this.btnDeleteFrm);
            this.Controls.Add(this.btnModifyFrm);
            this.Controls.Add(this.grpInsertSessions);
            this.Controls.Add(this.dgvSessions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInsertSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmInsertSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.grpInsertSessions.ResumeLayout(false);
            this.grpInsertSessions.PerformLayout();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
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
        private System.Windows.Forms.Label lblRoomsFilms;
        private System.Windows.Forms.ComboBox cmbFilmsIds;
        private System.Windows.Forms.ComboBox cmbFilms;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnInsert;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pibMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button btnResetSession;
    }
}
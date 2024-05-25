namespace ProyectoGreenSpace
{
    partial class FrmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTickets));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTicketOffice = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReviewTickets = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReviews = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnWriteReview = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblActualTickets = new System.Windows.Forms.Label();
            this.lblNumActualTickets = new System.Windows.Forms.Label();
            this.lblPastTickets = new System.Windows.Forms.Label();
            this.lblNumPastTickets = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvActualTickets = new System.Windows.Forms.DataGridView();
            this.numHall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceWithoutDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPastTickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastTicketsDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g2Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pibCloseFrm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.g2lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastTickets)).BeginInit();
            this.g2Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCloseFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(242, 700);
            this.sidebar.MinimumSize = new System.Drawing.Size(75, 700);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(242, 700);
            this.sidebar.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::ProyectoGreenSpace.Properties.Resources.menu_three_outlined_rounded_lines_symbol_icon_icons_com_73215;
            this.btnMenu.Location = new System.Drawing.Point(9, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(54, 53);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "   ";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseClick);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(85, 39);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(66, 23);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTicketOffice);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnTicketOffice
            // 
            this.btnTicketOffice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketOffice.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketOffice.Image")));
            this.btnTicketOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicketOffice.Location = new System.Drawing.Point(3, 3);
            this.btnTicketOffice.Name = "btnTicketOffice";
            this.btnTicketOffice.Size = new System.Drawing.Size(233, 52);
            this.btnTicketOffice.TabIndex = 22;
            this.btnTicketOffice.Text = "               Taquilla";
            this.btnTicketOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTicketOffice.UseVisualStyleBackColor = true;
            this.btnTicketOffice.Click += new System.EventHandler(this.btnTicketOffice_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReviewTickets);
            this.panel3.Location = new System.Drawing.Point(3, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 54);
            this.panel3.TabIndex = 2;
            // 
            // btnReviewTickets
            // 
            this.btnReviewTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnReviewTickets.Image")));
            this.btnReviewTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewTickets.Location = new System.Drawing.Point(3, 0);
            this.btnReviewTickets.Name = "btnReviewTickets";
            this.btnReviewTickets.Size = new System.Drawing.Size(233, 53);
            this.btnReviewTickets.TabIndex = 23;
            this.btnReviewTickets.Text = "          Revisar Tickets";
            this.btnReviewTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReviewTickets.UseVisualStyleBackColor = true;
            this.btnReviewTickets.Click += new System.EventHandler(this.btnReviewTickets_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReviews);
            this.panel4.Location = new System.Drawing.Point(3, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 62);
            this.panel4.TabIndex = 3;
            // 
            // btnReviews
            // 
            this.btnReviews.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Image = ((System.Drawing.Image)(resources.GetObject("btnReviews.Image")));
            this.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviews.Location = new System.Drawing.Point(3, 5);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(233, 54);
            this.btnReviews.TabIndex = 24;
            this.btnReviews.Text = "            Ver Reseñas";
            this.btnReviews.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnWriteReview);
            this.panel5.Location = new System.Drawing.Point(3, 304);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 68);
            this.panel5.TabIndex = 4;
            // 
            // btnWriteReview
            // 
            this.btnWriteReview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteReview.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteReview.Image")));
            this.btnWriteReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteReview.Location = new System.Drawing.Point(3, 7);
            this.btnWriteReview.Name = "btnWriteReview";
            this.btnWriteReview.Size = new System.Drawing.Size(233, 58);
            this.btnWriteReview.TabIndex = 24;
            this.btnWriteReview.Text = "          Escribir Reseña";
            this.btnWriteReview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWriteReview.UseVisualStyleBackColor = true;
            this.btnWriteReview.Click += new System.EventHandler(this.btnWriteReview_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 378);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 176);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnUser);
            this.panel7.Location = new System.Drawing.Point(3, 560);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(239, 56);
            this.panel7.TabIndex = 6;
            // 
            // btnUser
            // 
            this.btnUser.Enabled = false;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(233, 52);
            this.btnUser.TabIndex = 24;
            this.btnUser.Text = "               Usuario";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSettings);
            this.panel8.Location = new System.Drawing.Point(3, 622);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(239, 54);
            this.panel8.TabIndex = 7;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(233, 48);
            this.btnSettings.TabIndex = 24;
            this.btnSettings.Text = "          Configuración";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // lblActualTickets
            // 
            this.lblActualTickets.AutoSize = true;
            this.lblActualTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTickets.Location = new System.Drawing.Point(293, 70);
            this.lblActualTickets.Name = "lblActualTickets";
            this.lblActualTickets.Size = new System.Drawing.Size(175, 23);
            this.lblActualTickets.TabIndex = 31;
            this.lblActualTickets.Text = "Tickets actuales: ";
            // 
            // lblNumActualTickets
            // 
            this.lblNumActualTickets.AutoSize = true;
            this.lblNumActualTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActualTickets.Location = new System.Drawing.Point(483, 70);
            this.lblNumActualTickets.Name = "lblNumActualTickets";
            this.lblNumActualTickets.Size = new System.Drawing.Size(29, 23);
            this.lblNumActualTickets.TabIndex = 32;
            this.lblNumActualTickets.Text = "nº";
            // 
            // lblPastTickets
            // 
            this.lblPastTickets.AutoSize = true;
            this.lblPastTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastTickets.Location = new System.Drawing.Point(293, 368);
            this.lblPastTickets.Name = "lblPastTickets";
            this.lblPastTickets.Size = new System.Drawing.Size(174, 23);
            this.lblPastTickets.TabIndex = 33;
            this.lblPastTickets.Text = "Tickets pasados: ";
            // 
            // lblNumPastTickets
            // 
            this.lblNumPastTickets.AutoSize = true;
            this.lblNumPastTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPastTickets.Location = new System.Drawing.Point(483, 368);
            this.lblNumPastTickets.Name = "lblNumPastTickets";
            this.lblNumPastTickets.Size = new System.Drawing.Size(29, 23);
            this.lblNumPastTickets.TabIndex = 34;
            this.lblNumPastTickets.Text = "nº";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1093, 57);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 36);
            this.txtSearch.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ProyectoGreenSpace.Properties.Resources.lupa;
            this.btnSearch.Location = new System.Drawing.Point(1050, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvActualTickets
            // 
            this.dgvActualTickets.AllowUserToDeleteRows = false;
            this.dgvActualTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numHall,
            this.user,
            this.movie,
            this.day,
            this.schedule,
            this.duration,
            this.tickets,
            this.priceWithoutDiscount,
            this.discount,
            this.total});
            this.dgvActualTickets.Location = new System.Drawing.Point(262, 109);
            this.dgvActualTickets.Name = "dgvActualTickets";
            this.dgvActualTickets.ReadOnly = true;
            this.dgvActualTickets.RowHeadersWidth = 51;
            this.dgvActualTickets.RowTemplate.Height = 24;
            this.dgvActualTickets.Size = new System.Drawing.Size(1038, 210);
            this.dgvActualTickets.TabIndex = 37;
            // 
            // numHall
            // 
            this.numHall.HeaderText = "Nº Sala";
            this.numHall.MinimumWidth = 6;
            this.numHall.Name = "numHall";
            this.numHall.ReadOnly = true;
            this.numHall.Width = 70;
            // 
            // user
            // 
            this.user.HeaderText = "Usuario";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 125;
            // 
            // movie
            // 
            this.movie.HeaderText = "Película";
            this.movie.MinimumWidth = 6;
            this.movie.Name = "movie";
            this.movie.ReadOnly = true;
            this.movie.Width = 125;
            // 
            // day
            // 
            this.day.HeaderText = "Dia";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 125;
            // 
            // schedule
            // 
            this.schedule.HeaderText = "Horario";
            this.schedule.MinimumWidth = 6;
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            this.schedule.Width = 125;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duración";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 125;
            // 
            // tickets
            // 
            this.tickets.HeaderText = "Tickets";
            this.tickets.MinimumWidth = 6;
            this.tickets.Name = "tickets";
            this.tickets.ReadOnly = true;
            this.tickets.Width = 70;
            // 
            // priceWithoutDiscount
            // 
            this.priceWithoutDiscount.HeaderText = "Precio sin descuento";
            this.priceWithoutDiscount.MinimumWidth = 6;
            this.priceWithoutDiscount.Name = "priceWithoutDiscount";
            this.priceWithoutDiscount.ReadOnly = true;
            this.priceWithoutDiscount.Width = 125;
            // 
            // discount
            // 
            this.discount.HeaderText = "Descuento";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // dgvPastTickets
            // 
            this.dgvPastTickets.AllowUserToDeleteRows = false;
            this.dgvPastTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.pastTicketsDay,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvPastTickets.Location = new System.Drawing.Point(262, 409);
            this.dgvPastTickets.Name = "dgvPastTickets";
            this.dgvPastTickets.ReadOnly = true;
            this.dgvPastTickets.RowHeadersWidth = 51;
            this.dgvPastTickets.RowTemplate.Height = 24;
            this.dgvPastTickets.Size = new System.Drawing.Size(1038, 291);
            this.dgvPastTickets.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Sala";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Película";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // pastTicketsDay
            // 
            this.pastTicketsDay.HeaderText = "Dia";
            this.pastTicketsDay.MinimumWidth = 6;
            this.pastTicketsDay.Name = "pastTicketsDay";
            this.pastTicketsDay.ReadOnly = true;
            this.pastTicketsDay.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Horario";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Duración";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tickets";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio sin descuento";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // g2Bar
            // 
            this.g2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g2Bar.Controls.Add(this.guna2PictureBox1);
            this.g2Bar.Controls.Add(this.pibMaximize);
            this.g2Bar.Controls.Add(this.pibCloseFrm);
            this.g2Bar.Controls.Add(this.g2lblTitle);
            this.g2Bar.Location = new System.Drawing.Point(241, 0);
            this.g2Bar.Name = "g2Bar";
            this.g2Bar.Size = new System.Drawing.Size(1092, 42);
            this.g2Bar.TabIndex = 49;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(960, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(35, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 39;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pibMaximize
            // 
            this.pibMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibMaximize.Image = global::ProyectoGreenSpace.Properties.Resources.maximizar;
            this.pibMaximize.ImageRotate = 0F;
            this.pibMaximize.Location = new System.Drawing.Point(1001, 8);
            this.pibMaximize.Name = "pibMaximize";
            this.pibMaximize.Size = new System.Drawing.Size(34, 25);
            this.pibMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMaximize.TabIndex = 38;
            this.pibMaximize.TabStop = false;
            // 
            // pibCloseFrm
            // 
            this.pibCloseFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibCloseFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibCloseFrm.Image = ((System.Drawing.Image)(resources.GetObject("pibCloseFrm.Image")));
            this.pibCloseFrm.ImageRotate = 0F;
            this.pibCloseFrm.Location = new System.Drawing.Point(1041, 3);
            this.pibCloseFrm.Name = "pibCloseFrm";
            this.pibCloseFrm.Size = new System.Drawing.Size(39, 33);
            this.pibCloseFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCloseFrm.TabIndex = 37;
            this.pibCloseFrm.TabStop = false;
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.g2Bar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 715);
            this.Controls.Add(this.g2Bar);
            this.Controls.Add(this.dgvPastTickets);
            this.Controls.Add(this.dgvActualTickets);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumPastTickets);
            this.Controls.Add(this.lblPastTickets);
            this.Controls.Add(this.lblNumActualTickets);
            this.Controls.Add(this.lblActualTickets);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTickets";
            this.Load += new System.EventHandler(this.FrmTickets_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastTickets)).EndInit();
            this.g2Bar.ResumeLayout(false);
            this.g2Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCloseFrm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTicketOffice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReviewTickets;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnWriteReview;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label lblActualTickets;
        private System.Windows.Forms.Label lblNumActualTickets;
        private System.Windows.Forms.Label lblPastTickets;
        private System.Windows.Forms.Label lblNumPastTickets;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvActualTickets;
        private System.Windows.Forms.DataGridView dgvPastTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn numHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceWithoutDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastTicketsDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Guna.UI2.WinForms.Guna2Panel g2Bar;
        private Guna.UI2.WinForms.Guna2HtmlLabel g2lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pibMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pibCloseFrm;
    }
}
namespace ProyectoGreenSpace
{
    partial class FrmReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReviews));
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
            this.btnDeveloping = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlReviews = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lstStars = new System.Windows.Forms.ListBox();
            this.lstMovie = new System.Windows.Forms.ListBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.sidebar.MaximumSize = new System.Drawing.Size(242, 728);
            this.sidebar.MinimumSize = new System.Drawing.Size(75, 728);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(242, 728);
            this.sidebar.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 120);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::ProyectoGreenSpace.Properties.Resources.menu_three_outlined_rounded_lines_symbol_icon_icons_com_73215;
            this.btnMenu.Location = new System.Drawing.Point(9, 24);
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
            this.panel1.Location = new System.Drawing.Point(3, 129);
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
            this.btnTicketOffice.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReviewTickets);
            this.panel3.Location = new System.Drawing.Point(3, 196);
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
            this.btnReviewTickets.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReviews);
            this.panel4.Location = new System.Drawing.Point(3, 256);
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
            this.btnReviews.Text = "               Reseñas";
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeveloping);
            this.panel5.Location = new System.Drawing.Point(3, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 68);
            this.panel5.TabIndex = 4;
            // 
            // btnDeveloping
            // 
            this.btnDeveloping.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeveloping.Image = ((System.Drawing.Image)(resources.GetObject("btnDeveloping.Image")));
            this.btnDeveloping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeveloping.Location = new System.Drawing.Point(3, 7);
            this.btnDeveloping.Name = "btnDeveloping";
            this.btnDeveloping.Size = new System.Drawing.Size(233, 58);
            this.btnDeveloping.TabIndex = 24;
            this.btnDeveloping.Text = "          En Desarrollo";
            this.btnDeveloping.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 398);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 210);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnUser);
            this.panel7.Location = new System.Drawing.Point(3, 614);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(239, 56);
            this.panel7.TabIndex = 6;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(233, 52);
            this.btnUser.TabIndex = 24;
            this.btnUser.Text = "               Usuario";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSettings);
            this.panel8.Location = new System.Drawing.Point(3, 676);
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
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // pnlReviews
            // 
            this.pnlReviews.AutoScroll = true;
            this.pnlReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReviews.Location = new System.Drawing.Point(242, 0);
            this.pnlReviews.Name = "pnlReviews";
            this.pnlReviews.Size = new System.Drawing.Size(1029, 740);
            this.pnlReviews.TabIndex = 31;
            this.pnlReviews.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlReviews_Scroll);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // lstStars
            // 
            this.lstStars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStars.FormattingEnabled = true;
            this.lstStars.ItemHeight = 23;
            this.lstStars.Items.AddRange(new object[] {
            "Estrellas:",
            "",
            "5 estrellas",
            "4 estrellas",
            "3 estrellas",
            "2 estrellas",
            "1 estrella"});
            this.lstStars.Location = new System.Drawing.Point(245, 3);
            this.lstStars.Name = "lstStars";
            this.lstStars.Size = new System.Drawing.Size(238, 165);
            this.lstStars.TabIndex = 32;
            // 
            // lstMovie
            // 
            this.lstMovie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMovie.FormattingEnabled = true;
            this.lstMovie.ItemHeight = 23;
            this.lstMovie.Items.AddRange(new object[] {
            "Película:",
            "",
            "Peli 1",
            "Peli 2",
            "Peli 3",
            "Peli 4",
            "Peli 5",
            "Peli 6",
            "Peli 7",
            "Peli 8"});
            this.lstMovie.Location = new System.Drawing.Point(489, 3);
            this.lstMovie.Name = "lstMovie";
            this.lstMovie.Size = new System.Drawing.Size(238, 234);
            this.lstMovie.TabIndex = 33;
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 23;
            this.lstOrder.Items.AddRange(new object[] {
            "Filtrar por:",
            "",
            "Más recientes",
            "Menos recientes",
            "Más estrellas",
            "Menos estrellas"});
            this.lstOrder.Location = new System.Drawing.Point(972, 3);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(238, 142);
            this.lstOrder.TabIndex = 34;
            // 
            // FrmReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 740);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lstMovie);
            this.Controls.Add(this.lstStars);
            this.Controls.Add(this.pnlReviews);
            this.Controls.Add(this.sidebar);
            this.Name = "FrmReviews";
            this.Text = "FrmReviews";
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnDeveloping;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlReviews;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.ListBox lstStars;
        private System.Windows.Forms.ListBox lstMovie;
        private System.Windows.Forms.ListBox lstOrder;
    }
}
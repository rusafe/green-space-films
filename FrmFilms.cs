using ProyectoGreenSpace.LangResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmFilms : Form
    {
        bool sidebarExpand;
        public FrmFilms()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyLanguage()
        {
            lblMenu.Text = StringResources.labelMenu;
            btnTicketOffice.Text = StringResources.buttonTicketOffice;
            btnReviewTickets.Text = StringResources.buttonReviewTickets;
            btnReviews.Text = StringResources.buttonReviews;
            btnWriteReview.Text = StringResources.buttonWriteReview;
            btnUser.Text = StringResources.buttonUser;
            btnSettings.Text = StringResources.buttonConfiguration;
            lblTitleMonth.Text = StringResources.labelTitle;
            lblTitleNextMonth.Text = StringResources.labelNextTitle;
            lblJoinApp.Text = StringResources.labelJoinApp;
            lblLogOut.Text = StringResources.labelLogOut;
            lblUsername.Text = StringResources.labelUser;
        }

        private void FrmFilms_Load(object sender, EventArgs e)
        {
            NotVisibleUserButtons();

            txtUsername.Text = UserSession.Username;
            txtJoinApp.Text = UserSession.CreationDateTime.ToString("dd/MM/yyyy");

            ApplyLanguage();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_MouseClick_1(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    sidebarTimer.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    sidebarTimer.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void vsbFilms_Scroll(object sender, ScrollEventArgs e)
        {
            //pnlFilms.AutoScroll = false;
            //pnlFilms.VerticalScroll.Value = vsbFilms.Value;
            pnlFilms.AutoScrollPosition = new Point(0, e.NewValue);
        }

        private void ApplyTheme()
        {
            if (ThemeMode.Light == true)
            {
                grbMovie1.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie2.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie4.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie5.BackColor = Color.FromArgb(168, 228, 116);
                grbMovie6.BackColor = Color.FromArgb(168, 228, 116);
                grbMovie7.BackColor = Color.FromArgb(168, 228, 116);
                grbMovie8.BackColor = Color.FromArgb(168, 228, 116);
                grbNextMovie1.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie2.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie4.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie5.BackColor = Color.FromArgb(168, 228, 116);
                grbNextMovie6.BackColor = Color.FromArgb(168, 228, 116);
                grbNextMovie7.BackColor = Color.FromArgb(168, 228, 116);
                grbNextMovie8.BackColor = Color.FromArgb(168, 228, 116);

                pcbMovie1.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie2.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie3.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie4.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie5.BackColor = Color.FromArgb(176, 164, 180);
                pcbMovie6.BackColor = Color.FromArgb(176, 164, 180);
                pcbMovie7.BackColor = Color.FromArgb(176, 164, 180);
                pcbMovie8.BackColor = Color.FromArgb(176, 164, 180);
                pcbNextMovie1.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie2.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie3.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie4.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie5.BackColor = Color.FromArgb(176, 164, 180);
                pcbNextMovie6.BackColor = Color.FromArgb(176, 164, 180);
                pcbNextMovie7.BackColor = Color.FromArgb(176, 164, 180);
                pcbNextMovie8.BackColor = Color.FromArgb(176, 164, 180);

                sidebar.BackColor = Color.FromArgb(168, 228, 116);
                btnMenu.BackColor = Color.FromArgb(168, 228, 116);
                btnTicketOffice.BackColor = Color.FromArgb(168, 228, 116);
                btnReviewTickets.BackColor = Color.FromArgb(168, 228, 116);
                btnReviews.BackColor = Color.FromArgb(168, 228, 116);
                btnUser.BackColor = Color.FromArgb(168, 228, 116);
                btnSettings.BackColor = Color.FromArgb(168, 228, 116);
                btnWriteReview.BackColor = Color.FromArgb(168, 228, 116);
            }
            else
            {
                grbMovie1.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie2.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie4.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie5.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie6.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie7.BackColor = Color.FromArgb(176, 164, 180);
                grbMovie8.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie1.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie2.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie3.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie4.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie5.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie6.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie7.BackColor = Color.FromArgb(176, 164, 180);
                grbNextMovie8.BackColor = Color.FromArgb(176, 164, 180);

                pcbMovie1.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie2.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie3.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie4.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie5.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie6.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie7.BackColor = Color.FromArgb(168, 228, 116);
                pcbMovie8.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie1.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie2.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie3.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie4.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie5.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie6.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie7.BackColor = Color.FromArgb(168, 228, 116);
                pcbNextMovie8.BackColor = Color.FromArgb(168, 228, 116);

                sidebar.BackColor = Color.FromArgb(176, 164, 180);
                btnMenu.BackColor = Color.FromArgb(176, 164, 180);
                btnTicketOffice.BackColor = Color.FromArgb(176, 164, 180);
                btnReviewTickets.BackColor = Color.FromArgb(176, 164, 180);
                btnReviews.BackColor = Color.FromArgb(176, 164, 180);
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnSettings.BackColor = Color.FromArgb(176, 164, 180);
                btnWriteReview.BackColor = Color.FromArgb(176, 164, 180);
                pnlFilms.BackColor = Color.FromArgb(32, 146, 14);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pibClose.Visible = true;
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblJoinApp.Visible = true;
            txtJoinApp.Visible = true;
            lblLogOut.Visible = true;
        }
        private void pibClose_Click(object sender, EventArgs e)
        {
            NotVisibleUserButtons();
        }

        private void NotVisibleUserButtons()
        {
            pibClose.Visible = false;
            lblUsername.Visible = false;
            txtUsername.Visible = false;
            lblJoinApp.Visible = false;
            txtJoinApp.Visible = false;
            lblLogOut.Visible = false;
        }

        #region Acceso a formularios desde menú desplegable

        private void pcbMovie1_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie2_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie3_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie4_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie5_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie6_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie7_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbMovie8_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie1_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie2_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie3_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie4_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie5_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie6_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie7_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void pcbNextMovie8_Click(object sender, EventArgs e)
        {
            AccessMovieTheater();
        }

        private void btnReviewTickets_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            this.Close();
        }

        private void btnTicketOffice_Click(object sender, EventArgs e)
        {
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
            this.Close();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            FrmReviews frmReviews = new FrmReviews();
            frmReviews.Show();
            this.Close();
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            FrmWriteReview frmWriteReview = new FrmWriteReview();
            frmWriteReview.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Close();
        }

        private void AccessMovieTheater()
        {
            FrmMovieTheater frmMovieTheater = new FrmMovieTheater();
            frmMovieTheater.Show();
            this.Close();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
        #endregion
    }
}

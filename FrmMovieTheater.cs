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
    public partial class FrmMovieTheater : Form
    {
        bool sidebarExpand;
        public FrmMovieTheater()
        {
            InitializeComponent();
            sidebar.BackColor = Color.FromArgb(168, 228, 116);
            btnMenu.BackColor = Color.FromArgb(168, 228, 116);
            btnTicketOffice.BackColor = Color.FromArgb(168, 228, 116);
            btnReviewTickets.BackColor = Color.FromArgb(168, 228, 116);
            btnReviews.BackColor = Color.FromArgb(168, 228, 116);
            btnUser.BackColor = Color.FromArgb(168, 228, 116);
            btnSettings.BackColor = Color.FromArgb(168, 228, 116);
            btnWriteReview.BackColor = Color.FromArgb(168, 228, 116);
            txtInfoMovie.BackColor = Color.FromArgb(176, 164, 180);
        }
        private void AplicarIdioma()
        {
            lblMenu.Text = StringResources.labelMenu;
            btnTicketOffice.Text = StringResources.buttonTicketOffice;
            btnReviewTickets.Text = StringResources.buttonReviewTickets;
            btnReviews.Text = StringResources.buttonReviews;
            btnWriteReview.Text = StringResources.buttonWriteReview;
            btnUser.Text = StringResources.buttonUser;
            btnSettings.Text = StringResources.buttonConfiguration;
            lblSynopsis.Text = StringResources.labelSynopsis;
        }

        private void FrmMovieTheater_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        #region Acceso a formularios desde menú desplegable
        private void btnTicketOffice_Click(object sender, EventArgs e)
        {
            AccessFilms();
        }

        private void btnReviewTickets_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            this.Close();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            AccessReviews();
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            FrmWriteReview frmWriteReview = new FrmWriteReview();
            frmWriteReview.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmAdmin frmConfiguration = new FrmAdmin();
            frmConfiguration.Show();
            this.Close();
        }

        private void btnAccessRevews_Click(object sender, EventArgs e)
        {
            AccessReviews();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessFilms();
        }

        private void AccessFilms ()
        {
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
            this.Close();
        }

        private void AccessReviews()
        {
            FrmReviews frmReviews = new FrmReviews();
            frmReviews.Show();
            this.Close();
        }

        private void grpInfo1_Enter(object sender, EventArgs e)
        {
            AccessPayInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            AccessPayInfo();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            AccessPayInfo();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            AccessPayInfo();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            AccessPayInfo();
        }
        private void AccessPayInfo()
        {
            FrmPayInfo frmPayInfo = new FrmPayInfo();
            frmPayInfo.Show();
            this.Close();
        }
        #endregion

    }
}
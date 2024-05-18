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
    public partial class FrmReviews : Form
    {
        bool sidebarExpand;

        public FrmReviews()
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
            pnlReviews.BackColor = Color.FromArgb(176, 164, 180);

            grpReview1.BackColor = Color.White;
            grpReview2.BackColor = Color.White;
            grpReview3.BackColor = Color.White;
            grpReview4.BackColor = Color.White;
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

        private void pnlReviews_Scroll(object sender, ScrollEventArgs e)
        {
            pnlReviews.AutoScrollPosition = new Point(0, e.NewValue);

        }

        #region Acceso a formularios desde menú desplegable
        private void btnTicketOffice_Click(object sender, EventArgs e)
        {
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
            this.Close();
        }

        private void btnReviewTickets_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
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
            FrmAdmin frmConfiguration = new FrmAdmin();
            frmConfiguration.Show();
            this.Close();
        }
        #endregion
    }
}

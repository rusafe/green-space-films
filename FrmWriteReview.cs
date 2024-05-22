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
    public partial class FrmWriteReview : Form
    {
        bool sidebarExpand;
        public FrmWriteReview()
        {
            InitializeComponent();

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                sidebar.BackColor = Color.FromArgb(168, 228, 116);
                btnMenu.BackColor = Color.FromArgb(168, 228, 116);
                btnTicketOffice.BackColor = Color.FromArgb(168, 228, 116);
                btnReviewTickets.BackColor = Color.FromArgb(168, 228, 116);
                btnReviews.BackColor = Color.FromArgb(168, 228, 116);
                btnUser.BackColor = Color.FromArgb(168, 228, 116);
                btnSettings.BackColor = Color.FromArgb(168, 228, 116);
                btnWriteReview.BackColor = Color.FromArgb(168, 228, 116);
                grpReview.BackColor = Color.FromArgb(168, 228, 116);

                pctStar1.BackColor = Color.FromArgb(168, 228, 116);
                pctStar2.BackColor = Color.FromArgb(168, 228, 116);
                pctStar3.BackColor = Color.FromArgb(168, 228, 116);
                pctStar4.BackColor = Color.FromArgb(168, 228, 116);
                pctStar5.BackColor = Color.FromArgb(168, 228, 116);
                pctStar6.BackColor = Color.FromArgb(168, 228, 116);
                pctStar7.BackColor = Color.FromArgb(168, 228, 116);
                pctStar8.BackColor = Color.FromArgb(168, 228, 116);
                pctStar9.BackColor = Color.FromArgb(168, 228, 116);
                pctStar10.BackColor = Color.FromArgb(168, 228, 116);
                pctStar11.BackColor = Color.FromArgb(168, 228, 116);
                pctStar12.BackColor = Color.FromArgb(168, 228, 116);
                pctStar13.BackColor = Color.FromArgb(168, 228, 116);
                pctStar14.BackColor = Color.FromArgb(168, 228, 116);
                pctStar15.BackColor = Color.FromArgb(168, 228, 116);
                cklStars.BackColor = Color.FromArgb(168, 228, 116);
            }
            else
            {
                sidebar.BackColor = Color.FromArgb(176, 164, 180);
                btnMenu.BackColor = Color.FromArgb(176, 164, 180);
                btnTicketOffice.BackColor = Color.FromArgb(176, 164, 180);
                btnReviewTickets.BackColor = Color.FromArgb(176, 164, 180);
                btnReviews.BackColor = Color.FromArgb(176, 164, 180);
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnSettings.BackColor = Color.FromArgb(176, 164, 180);
                btnWriteReview.BackColor = Color.FromArgb(176, 164, 180);
                pnlReviews.BackColor = Color.FromArgb(32, 146, 14);

                pctStar1.BackColor = Color.FromArgb(32, 146, 14);
                pctStar2.BackColor = Color.FromArgb(32, 146, 14);
                pctStar3.BackColor = Color.FromArgb(32, 146, 14);
                pctStar4.BackColor = Color.FromArgb(32, 146, 14);
                pctStar5.BackColor = Color.FromArgb(32, 146, 14);
                pctStar6.BackColor = Color.FromArgb(32, 146, 14);
                pctStar7.BackColor = Color.FromArgb(32, 146, 14);
                pctStar8.BackColor = Color.FromArgb(32, 146, 14);
                pctStar9.BackColor = Color.FromArgb(32, 146, 14);
                pctStar10.BackColor = Color.FromArgb(32, 146, 14);
                pctStar11.BackColor = Color.FromArgb(32, 146, 14);
                pctStar12.BackColor = Color.FromArgb(32, 146, 14);
                pctStar13.BackColor = Color.FromArgb(32, 146, 14);
                pctStar14.BackColor = Color.FromArgb(32, 146, 14);
                pctStar15.BackColor = Color.FromArgb(32, 146, 14);
                cklStars.BackColor = Color.FromArgb(32, 146, 14);
            }
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
            lblTitleReview.Text = StringResources.labelReviewTitle;
            btnReset.Text = StringResources.buttonReset;
            btnSend.Text = StringResources.buttonSendReview;
            lblJoinApp.Text = StringResources.labelJoinApp;
            lblLogOut.Text = StringResources.labelLogOut;
            lblUsername.Text = StringResources.labelUser;
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

        private void btnUser_Click(object sender, EventArgs e)
        {
            pibClose.Visible = true;
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblJoinApp.Visible = true;
            txtJoinApp.Visible = true;
            lblLogOut.Visible = true;
        }

        private void FrmWriteReview_Load(object sender, EventArgs e)
        {
            NotVisibleUserButtons();
            ApplyLanguage();

            txtUsername.Text = UserSession.Username;
            txtJoinApp.Text = UserSession.CreationDateTime.ToString("dd/MM/yyyy");
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

        private void cklStars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < cklStars.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        cklStars.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            rtxReview1.Text = string.Empty;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Enviar a la base de datos
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            NotVisibleUserButtons();
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
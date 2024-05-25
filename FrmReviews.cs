using ProyectoGreenSpace.Classes;
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
    public partial class FrmReviews : Form
    {
        bool sidebarExpand;

        public FrmReviews()
        {
            InitializeComponent();
            
            ApplyTheme();
            grpReview1.BackColor = Color.White;
            grpReview2.BackColor = Color.White;
            grpReview3.BackColor = Color.White;
            grpReview4.BackColor = Color.White;
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
            }
        }

        private void LoadFilmReviews(string filmName)
        {
            List<Review> reviews = Review.ObtainReviews(Film.InfoFilm(filmName).Id, 4);

            for (int i = 0; i < reviews.Count; i++)
            {
                string grbReviewName = $"grbReview{i + 1}";
                string lblTitleReviewName = $"lblTitleReview{i + 1}";
                string rtxReviewName = $"rtxReview{i + 1}";
                string lblNameReviewName = $"lblNameReview{i + 1}";
                string lblAntiquityReviewName = $"lblAntiquityReview{i + 1}";
                string lblPunctuationReviewName = $"lblPunctuationReview{i + 1}";
                string lblDateReviewName = $"lblDateReview{i + 1}";
                string pctReviewName = $"pctReview{i + 1}";

                GroupBox grbSession = (GroupBox)this.Controls.Find(grbReviewName, true)[0];
                grbSession.Visible = true;

                //Label lblSessionId = (Label)grbSession.Controls.Find(lblSessionIdName, true)[0];
                //lblSessionId.Text = sessions[i].Id.ToString();

                //TextBox txtSessionHour = (TextBox)grbSession.Controls.Find(txtHourName, true)[0];
                //txtSessionHour.Text = sessions[i].StartHour.ToString();

                //Room room = sessions[i].getRoom();

                //TextBox txtSessionHall = (TextBox)grbSession.Controls.Find(txtHallName, true)[0];
                //txtSessionHall.Text = $"Sala {room.Id}";

                //TextBox txtSessionHallType = (TextBox)grbSession.Controls.Find(txtHallTypeName, true)[0];
                //txtSessionHallType.Text = room.Type;

                //Label lblAmountFreeSeats = (Label)grbSession.Controls.Find(lblFreeSeatsName, true)[0];
                //lblAmountFreeSeats.Text = sessions[i].FreeSeats().ToString();

                //Label lblAmountOccupiedSeats = (Label)grbSession.Controls.Find(lblOccupiedSeatsName, true)[0];
                //lblAmountOccupiedSeats.Text = sessions[i].OccupiedSeats.ToString();
            }
        }

        private void FrmReviews_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

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

        private void pnlReviews_Scroll(object sender, ScrollEventArgs e)
        {
            pnlReviews.AutoScrollPosition = new Point(0, e.NewValue);

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
            cmbStars.Text = StringResources.comboStars;
            cmbMovies.Text = StringResources.comboMovies;
            cmbOrder.Text = StringResources.comboOrder;
            lblJoinApp.Text = StringResources.labelJoinApp;
            lblLogOut.Text = StringResources.labelLogOut;
            lblUsername.Text = StringResources.labelUser;
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

        private void btnUser_Click(object sender, EventArgs e)
        {
            pibClose.Visible = true;
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblJoinApp.Visible = true;
            txtJoinApp.Visible = true;
            lblLogOut.Visible = true;
        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
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

        #region Diseño de barra minimizadora
        private void pibMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void pibMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pibCloseFrm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
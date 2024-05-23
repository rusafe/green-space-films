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
    public partial class FrmMovieTheater : Form
    {
        private Film film;

        bool sidebarExpand;
        
        public FrmMovieTheater(string filmName)
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

            film = Film.InfoFilm(filmName);
            LoadFilmInfo(film);
            LoadFilmSessions(film);
        }

        private void AccessSelectSeats(int sessionId)
        {
            FrmSelectSeats frmSelectSeats = new FrmSelectSeats(sessionId);
            frmSelectSeats.Show();
            this.Close();
        }

        private void FrmMovieTheater_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
        }

        private void LoadFilmInfo(Film film)
        {
            pcbMovie1.Image = film.Cover;
            txtInfoMovie.Text = film.Synopsis;
            txtDuration.Text = film.Duration.ToString();
            txtAge.Text = film.MinAge.ToString();
            txtGender1.Text = film.Genres[0];
            txtGender2.Text = film.Genres[1];
        }

        private void LoadFilmSessions(Film film)
        {
            List<Session> sessions = Session.ObtainAllSessions(film.Id);

            for (int i = 0; i < sessions.Count; i++)
            {
                string grbSessionName = $"grbInfo{i + 1}";
                string lblSessionIdName = $"lblSessionId{i + 1}";
                string txtHourName = $"txtHour{i + 1}";
                string txtHallName = $"txtHall{i + 1}";
                string txtHallTypeName = $"txtTypeHall{i + 1}";
                string lblFreeSeatsName = $"lblAmountFreeSeats{i + 1}";
                string lblOccupiedSeatsName = $"lblAmountOccupiedSeats{i + 1}";

                GroupBox grbSession = (GroupBox)this.Controls.Find(grbSessionName, true)[0];
                grbSession.Visible = true;

                Label lblSessionId = (Label)grbSession.Controls.Find(lblSessionIdName, true)[0];
                lblSessionId.Text = sessions[i].Id.ToString();

                TextBox txtSessionHour = (TextBox)grbSession.Controls.Find(txtHourName, true)[0];
                txtSessionHour.Text = sessions[i].StartHour.ToString();

                Room room = sessions[i].getRoom();

                TextBox txtSessionHall = (TextBox)grbSession.Controls.Find(txtHallName, true)[0];
                txtSessionHall.Text = $"Sala {room.Id}";

                TextBox txtSessionHallType = (TextBox)grbSession.Controls.Find(txtHallTypeName, true)[0];
                txtSessionHallType.Text = room.Type;

                Label lblAmountFreeSeats = (Label)grbSession.Controls.Find(lblFreeSeatsName, true)[0];
                lblAmountFreeSeats.Text = sessions[i].FreeSeats().ToString();

                Label lblAmountOccupiedSeats = (Label)grbSession.Controls.Find(lblOccupiedSeatsName, true)[0];
                lblAmountOccupiedSeats.Text = sessions[i].OccupiedSeats.ToString();
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
            lblSynopsis.Text = StringResources.labelSynopsis;
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

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        #region Acceso a formularios desde menú desplegable

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
            AccessSelectSeats(Convert.ToInt32(lblSessionId1.Text));
        }

        private void grbInfo2_Enter(object sender, EventArgs e)
        {
            AccessSelectSeats(Convert.ToInt32(lblSessionId2.Text));
        }

        private void grbInfo3_Enter(object sender, EventArgs e)
        {
            AccessSelectSeats(Convert.ToInt32(lblSessionId3.Text));
        }

        private void grbInfo4_Enter(object sender, EventArgs e)
        {
            AccessSelectSeats(Convert.ToInt32(lblSessionId4.Text));
        }

        private void grbInfo5_Enter(object sender, EventArgs e)
        {
            AccessSelectSeats(Convert.ToInt32(lblSessionId5.Text));
        }

        private void btnTicketOffice_Click_1(object sender, EventArgs e)
        {
            AccessFilms();
        }

        private void btnReviewTickets_Click_1(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            this.Close();
        }

        private void btnReviews_Click_1(object sender, EventArgs e)
        {
            AccessReviews();
        }

        private void btnWriteReview_Click_1(object sender, EventArgs e)
        {
            FrmWriteReview frmWriteReview = new FrmWriteReview();
            frmWriteReview.Show();
            this.Close();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
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

        private void pibClose_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
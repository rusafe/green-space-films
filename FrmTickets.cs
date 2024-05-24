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
    public partial class FrmTickets : Form
    {
        bool sidebarExpand;
        public FrmTickets()
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
                this.BackColor = Color.FromArgb(32, 146, 14);
            }
        }

        #region DGVs
        private void LoadActualTicketsDGV()
        {
            foreach (Ticket ticket in Ticket.ActualTickets(UserSession.Id))
            {
                User user = ticket.getUser();
                Film film = ticket.getFilm();
                Room room = ticket.getRoom();

                dgvActualTickets.Rows.Add(
                    $"Sala {room.Id}",
                    user.Username,
                    film.Name,
                    ticket.DateFilm.ToShortDateString(),
                    ticket.HourFilm,
                    film.Duration,
                    ticket.Quantity,
                    ticket.TotalPriceWithoutDiscount(),
                    $"{ticket.Discount} %",
                    ticket.TotalPrice()
                );
            }
        }

        private void LoadPastTicketsDGV()
        {
            foreach (Ticket ticket in Ticket.PastTickets(UserSession.Id))
            {
                User user = ticket.getUser();
                Film film = ticket.getFilm();
                Room room = ticket.getRoom();

                dgvActualTickets.Rows.Add(
                    room.Id,
                    user.Username,
                    film.Name,
                    ticket.HourFilm,
                    ticket.DateFilm.ToShortDateString(),
                    film.Duration,
                    ticket.Quantity,
                    ticket.IndividualPrice,
                    ticket.Discount,
                    ticket.TotalPrice()
                );
            }
        }
        #endregion

        private void FrmTickets_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            LoadActualTicketsDGV();
            LoadPastTicketsDGV();
            lblNumActualTickets.Text = Ticket.AmountActualTickets(UserSession.Id).ToString();
            lblNumPastTickets.Text = Ticket.AmountActualTickets(UserSession.Id).ToString();
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
            lblActualTickets.Text = StringResources.labelActualTickets;
            lblPastTickets.Text = StringResources.labelPastTickets;
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

using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.LangResources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmPayInfo : Form
    {
        private Ticket ticket;
        private Seats seats;
        private int seatsSelected;

        public FrmPayInfo(int sessionId, Bitmap seatsStatus, int seatsSelected)
        {
            InitializeComponent();
            grpInfo.BackColor = Color.FromArgb(168, 228, 116);

            this.seatsSelected = seatsSelected;
            this.seats = new Seats(sessionId, Seats.CreateSeatsArrayFromBitmap(seatsStatus));
            this.ticket = CreateTicket(Session.ObtainSession(sessionId), this.seatsSelected);
            LoadTicketInfo(this.ticket);
        }

        private void ApplyLanguage()
        {
            lblTitle.Text = StringResources.labelTitle;
            lblMovie.Text = StringResources.labelFilm;
            lblTypeHall.Text = StringResources.labelTypeHall;
            lblName.Text = StringResources.labelName;
            lblShedule.Text = StringResources.labelSchedule;
            lblDuration.Text = StringResources.labelDuration;
            lblSeats.Text = StringResources.labelTickets;
            lblDiscounts.Text = StringResources.labelDiscounts;
            lblDiscount.Text = StringResources.labelDiscount;
            lblTotal.Text = StringResources.labelTotal;
            lblTotalApplied.Text = StringResources.labelTotalApplied;
        }

        private Ticket CreateTicket(Session session, int seatsSelected)
        {
            Film film = session.getFilm();
            Room room = session.getRoom();

            ticket = new Ticket(
                UserSession.Id,
                film.Id,
                room.Id,
                DateTime.Now,
                DateTime.Now,
                session.StartHour,
                seatsSelected,
                film.Price,
                Ticket.AmountDiscount(seatsSelected)
            );

            return ticket;
        }

        private void LoadTicketInfo(Ticket ticket)
        {
            Film film = ticket.getFilm();
            Room room = ticket.getRoom();

            txtMovie.Text = film.Name;
            txtTypeHall.Text = room.Type;
            txtName.Text = UserSession.Username;
            txtShedule.Text = ticket.HourFilm.ToString();
            txtDuration.Text = film.Duration.ToString();
            txtSeats.Text = ticket.Quantity.ToString();
            txtDiscounts.Text = $"{ticket.Discount} %";

            lblTotalImport.Text = $"{ticket.TotalPriceWithoutDiscount():N} €";
            lblDiscountImport.Text = $"{ticket.PriceDiscounted():N} €";
            lblTotalImportApplied.Text = $"{ticket.TotalPrice():N} €";
        }

        private void FrmPayInfo_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMovieTheater frmMovieTheater = new FrmMovieTheater(txtMovie.Text);
            frmMovieTheater.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
            this.Dispose();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ticket.Create();

            Session.ObtainSession(seats.SessionId).OccupySeats(seatsSelected);
            seats.UploadSeatsStatus();
        }

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
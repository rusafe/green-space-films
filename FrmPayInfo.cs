using ProyectoGreenSpace.LangResources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmPayInfo : Form
    {
        public FrmPayInfo()
        {
            InitializeComponent();
            grpInfo.BackColor = Color.FromArgb(168, 228, 116);
            nudSeat.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void ApplyLanguage()
        {
            lblTitle.Text = StringResources.labelTitle;
            lblMovie.Text = StringResources.labelFilm;
            lblTypeHall.Text = StringResources.labelTypeHall;
            lblName.Text = StringResources.labelName;
            lblShedule.Text = StringResources.labelSchedule;
            lblDuration.Text = StringResources.labelDuration;
            lblTickets.Text = StringResources.labelTickets;
            lblSeating.Text = StringResources.labelSeating;
            lblDiscounts.Text = StringResources.labelDiscounts;
            lblDiscount.Text = StringResources.labelDiscount;
            lblTotal.Text = StringResources.labelTotal;
            lblTotalApplied.Text = StringResources.labelTotalApplied;
        }

        private void FrmPayInfo_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMovieTheater frmMovieTheater = new FrmMovieTheater();
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
        }
    }
}
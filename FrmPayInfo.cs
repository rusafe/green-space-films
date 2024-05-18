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
    public partial class FrmPayInfo : Form
    {
        public FrmPayInfo()
        {
            InitializeComponent();
            grpInfo.BackColor = Color.FromArgb(168, 228, 116);
            txtSeating.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void AplicarIdioma()
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
            // Pago de la película
        }
    }
}

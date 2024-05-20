using ProyectoGreenSpace.Classes;
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
    public partial class FrmMovieDelete : Form
    {
        public FrmMovieDelete()
        {
            InitializeComponent();
            grpClock.BackColor = Color.FromArgb(168, 228, 116);
            grpDelete.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void FrmMovieDelete_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Start();

            LoadListMovies();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbFilmsIds.Focus();
        }

        private void LoadListMovies()
        {
            dgvFilms.DataSource = Film.ObtainAll();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #region Acceso a formularios de admininstración
        private void btnInsertFrm_Click(object sender, EventArgs e)
        {
            FrmMovieMaintenance frmMovie = new FrmMovieMaintenance();
            frmMovie.Show();
            this.Close();
        }

        private void btnModifyFrm_Click(object sender, EventArgs e)
        {
            FrmMovieModify frmMovie = new FrmMovieModify();
            frmMovie.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }
        #endregion

        #region Diseño de interface
        private void grpClock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpClock.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void grpDelete_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpDelete.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pibImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pibImage.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        #endregion
    }
}

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
    public partial class FrmMovieModify : Form
    {
        public FrmMovieModify()
        {
            InitializeComponent();
            grpClock.BackColor = Color.FromArgb(168, 228, 116);
            grpModify.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void FrmMovieModify_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Start();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #region Acceso a formularios de administración
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }

        private void btnInsertFrm_Click(object sender, EventArgs e)
        {
            FrmMovieMaintenance frmMovieMaintenance = new FrmMovieMaintenance();
            frmMovieMaintenance.Show();
            this.Close();
        }

        private void btnDeleteFrm_Click(object sender, EventArgs e)
        {
            FrmMovieDelete frmMovieDelete = new FrmMovieDelete();
            frmMovieDelete.Show();
            this.Close();
        }
        #endregion

        #region Diseño de interface
        private void pibImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pibImage.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void grpModify_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpModify.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void grpClock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpClock.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        #endregion

    }
}

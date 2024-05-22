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
    public partial class FrmInsertSession : Form
    {
        public FrmInsertSession()
        {
            InitializeComponent();
            ApplyTheme();
            this.FormClosed += new FormClosedEventHandler(AppKill);
        }

        private void FrmInsertSession_Load(object sender, EventArgs e)
        {
            dtpHour.Value = DateTime.Now;
        }

        private void AppKill(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void ApplyTheme ()
        {
            if (ThemeMode.Light)
            {
                grpInsertSessions.BackColor = Color.FromArgb(168, 228, 116);
                btnInsert.BackColor = Color.FromArgb(76, 80, 144);
                btnInsertFrm.BackColor = Color.FromArgb(176, 164, 180);
                btnModifyFrm.BackColor = Color.FromArgb(176, 164, 180);
                btnDeleteFrm.BackColor = Color.FromArgb(176, 164, 180);
            }
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

        private void btnInsertSessions_Click(object sender, EventArgs e)
        {
            FrmInsertSession frmInsertSession = new FrmInsertSession();
            frmInsertSession.Show();
            this.Close();
        }
        #endregion
    }
}

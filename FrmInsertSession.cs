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
    public partial class FrmInsertSession : Form
    {
        public FrmInsertSession()
        {
            InitializeComponent();
            ApplyTheme();
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

        private void ApplyLanguage()
        {
            lblFilm.Text = StringResources.lblFilm;
            btnInsert.Text = StringResources.btnInsert;
            btnModifyFrm.Text = StringResources.btnModifyFrm;
            btnDeleteFrm.Text = StringResources.btnDeleteFrm;
            btnBack.Text = StringResources.buttonExit;
            btnInsertFrm.Text = StringResources.btnInsertFrm;
            lblHour.Text = StringResources.btnHour;
            lblRoomsFilms.Text = StringResources.labelRoomsFilms;
            btnResetSession.Text = StringResources.buttonResetSession;
        }

        private void ClearInputs()
        {
            cmbFilmsIds.Items.Clear();
            cmbFilms.Items.Clear();
            cmbRoomsFilms.Items.Clear();
            dtpHour.Value = DateTime.Now;

            SetFilmsIdentifyingValues();
            SetRoomsIdentifyingValues();
        }

        private void SetFilmsIdentifyingValues()
        {
            foreach (var values in Film.GetIdentifyingInfoPremiering())
            {
                cmbFilmsIds.Items.Add(values.id);
                cmbFilms.Items.Add(values.name);
            }
        }

        private void SetRoomsIdentifyingValues()
        {
            foreach (int roomId in Room.GetIdentifyingInfo())
            {
                cmbRoomsFilms.Items.Add(roomId);
            }
        }

        private void UpdateFilmInfoFields(Film film)
        {
            cmbFilmsIds.Text = film.Id.ToString();
            cmbFilms.Text = film.Name;
        }

        private void FrmInsertSession_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);
            dtpHour.Text = "12:00";
            
            ApplyLanguage();

            LoadListSessions();
            SetFilmsIdentifyingValues();
            SetRoomsIdentifyingValues();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dtpHour.Value;
                int hour = dt.Hour;
                int minute = dt.Minute;
                int second = dt.Second;

                Session session = new Session(
                    Convert.ToInt32(cmbFilmsIds.Text),
                    Convert.ToInt32(cmbRoomsFilms.Text),
                    new TimeSpan(hour, minute, second)
                );

                session.Create();
                LoadListSessions();

                ClearInputs();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFilmsIds_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFilmInfoFields(Film.InfoFilm(Convert.ToInt32(cmbFilmsIds.Text)));
        }

        private void cmbFilms_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFilmInfoFields(Film.InfoFilm(cmbFilms.Text));
        }

        private void btnResetSession_Click(object sender, EventArgs e)
        {
            Session.RestartSessions();
            MessageBox.Show("Todas las sesiones han sido restauradas", "Restaurar sesiones", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadListSessions()
        {
            dgvSessions.DataSource = Session.ObtainAll();
        }
        private void btnModifyFrm_Click(object sender, EventArgs e)
        {
            FrmMovieModify frmMovieModify = new FrmMovieModify();
            frmMovieModify.Show();
            this.Close();
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
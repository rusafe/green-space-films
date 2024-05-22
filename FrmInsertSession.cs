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
            dtpHour.Value = DateTime.Now;

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
        }

        private void cmbFilmsIds_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFilmInfoFields(Film.InfoFilm(Convert.ToInt32(cmbFilmsIds.Text)));
        }

        private void cmbFilms_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFilmInfoFields(Film.InfoFilm(cmbFilms.Text));
        }
    }
}

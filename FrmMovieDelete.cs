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
            SetFilmsIdentifyingValues();
            ApplyLanguage();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbFilmsIds.Focus();
        }

        #region Validaciones
        private bool ValidateInputs()
        {
            bool godrickElInjertado = true;
            if (String.IsNullOrEmpty(cmbFilms.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbFilms, "Inserta una película.");
            }
            else if (String.IsNullOrEmpty(cmbFilmsIds.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbFilms, "Inserta una película.");
            }
            return godrickElInjertado;
        }
        #endregion

        private void LoadListMovies()
        {
            dgvFilms.DataSource = Film.ObtainAll();
        }

        private void CleanData()
        {
            cmbFilms.Text = string.Empty;
            cmbFilmsIds.Text = string.Empty;
            rtbSynopsis.Text = string.Empty;
            lblDuration1.Text = string.Empty;
            lblPrice1.Text = string.Empty;
            lblMinAge1.Text = string.Empty;
            lblGenre1.Text = string.Empty;
            lblGenre2.Text = string.Empty;
        }

        private void ApplyLanguage()
        {
            lblFilm.Text = StringResources.lblFilm;
            lblSynopsis.Text = StringResources.lblSynopsis;
            lblDuration.Text = StringResources.lblDuration;
            lblMinAge.Text = StringResources.lblMinAge;
            lblPrice.Text = StringResources.lblPrice;
            lblGenre.Text = StringResources.lblGenre;
            btnInsertFrm.Text = StringResources.btnInsertFrm;
            grpDelete.Text = StringResources.groupBoxDelete;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                Film.Delete(Convert.ToInt32(cmbFilmsIds.Text));

                CleanData();
                LoadListMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Cargar valores  
        private void cmbFilmsIds_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateInputFields(Film.InfoFilm(Convert.ToInt32(cmbFilmsIds.Text)));
        }

        private void cmbFilms_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateInputFields(Film.InfoFilm(cmbFilms.Text));
        }
        private void UpdateInputFields(Film film)
        {
            cmbFilmsIds.Text = film.Id.ToString();
            cmbFilms.Text = film.Name;
            pibImage.Image = film.Cover;
            rtbSynopsis.Text = film.Synopsis;
            lblMinAge1.Text = film.MinAge.ToString();
            lblDuration1.Text = film.Duration.ToString();
            lblPrice1.Text = film.Price.ToString();
            lblGenre1.Text = film.Genres[0];
            lblGenre2.Text = film.Genres[1];
        }
        private void SetFilmsIdentifyingValues()
        {
            foreach (var values in Film.GetIdentifyingInfo())
            {
                cmbFilmsIds.Items.Add(values.id);
                cmbFilms.Items.Add(values.name);
            }
        }
        #endregion

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

        private void btnInsertSessions_Click(object sender, EventArgs e)
        {
            FrmInsertSession frmInsertSession = new FrmInsertSession();
            frmInsertSession.Show();
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
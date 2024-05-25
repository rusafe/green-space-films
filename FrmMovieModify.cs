using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.LangResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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

            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            LoadListMovies();
            ApplyLanguage();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            SetFilmsIdentifyingValues();

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

        #region Validaciones
        private bool ValidateInputs()
        {
            bool godrickElInjertado = true;
            errorProvider1.Clear();

            if (EmptyGenres())
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "Introduce dos géneros obligatoriamente.");
                errorProvider1.SetError(cmbGenre2, "Introduce dos géneros obligatoriamente.");
            }
            else if (SameGenres())
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "No es posible introducir el mismo genero varias veces.");
                errorProvider1.SetError(cmbGenre2, "No es posible introducir el mismo genero varias veces.");
            }
            else if (String.IsNullOrEmpty(cmbFilms.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbFilms, "Inserta una película.");
            }
            else if (String.IsNullOrEmpty(cmbFilmsIds.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbFilms, "Inserta una película.");
            }
            else if (String.IsNullOrEmpty(rtbSynopsis.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(rtbSynopsis, "Inserta una sinopsis.");
            }
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(txtPrice, "Inserta el precio.");
            }
            else if (String.IsNullOrEmpty(cmbGenre1.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre1, "Inserta el primer género.");
            }
            else if (String.IsNullOrEmpty(cmbGenre1.Text))
            {
                godrickElInjertado = false;
                errorProvider1.SetError(cmbGenre2, "Inserta el segundo género.");
            }
            else if (pibImage.Image == null)
            {
                godrickElInjertado = false;
                errorProvider1.SetError(btnUpload, "Inserta una imagen.");
            }
            else if (chbPremiering.Checked && chbNextPremiering.Checked)
            {
                godrickElInjertado = false;
                errorProvider1.SetError(chbPremiering, "Selecciona una única opción.");
                errorProvider1.SetError(chbNextPremiering, "Selecciona una única opción.");
            }

            return godrickElInjertado;
        }

        private bool SameGenres()
        {
            return cmbGenre1.Text.Equals(cmbGenre2.Text);
        }
        private bool EmptyGenres()
        {
            return string.IsNullOrEmpty(cmbGenre1.Text) || string.IsNullOrEmpty(cmbGenre2.Text);
        }
        #endregion

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                string[] genres = new string[]
                {
                    cmbGenre1.Text,
                    cmbGenre2.Text
                };

                Film film = new Film(
                    Convert.ToInt32(cmbFilmsIds.Text),
                    cmbFilms.Text,
                    rtbSynopsis.Text,
                    pibImage.Image,
                    TimeSpan.Parse(dtpHour.Text),
                    (int)nudMinAge.Value,
                    Convert.ToDouble(txtPrice.Text),
                    genres,
                    chbPremiering.Checked,
                    chbNextPremiering.Checked
                );

                film.Update();
                LoadListMovies();
                CleanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CleanData()
        {
            cmbFilms.Text = string.Empty;
            cmbFilmsIds.Text = string.Empty;
            rtbSynopsis.Text = string.Empty;
            dtpHour.Text = "12:00";
            txtPrice.Text = string.Empty;
            nudMinAge.Value = 0;
            cmbGenre1.Text = string.Empty;
            cmbGenre2.Text = string.Empty;
            chbPremiering.Checked = false;
            chbNextPremiering.Checked = false;
        }

        private void ApplyLanguage()
        {
            lblFilm.Text = StringResources.lblFilm;
            lblSynopsis.Text = StringResources.lblSynopsis;
            lblDuration.Text = StringResources.lblDuration;
            lblMinAge.Text = StringResources.lblMinAge;
            lblPrice.Text = StringResources.lblPrice;
            lblGenre.Text = StringResources.lblGenre;
            chbNextPremiering.Text = StringResources.chbNextPremiering;
            chbPremiering.Text = StringResources.chbPremiering;
            btnModify.Text = StringResources.btnUpdateFilm;
            btnInsertFrm.Text = StringResources.btnInsertFrm;
            btnDeleteFrm.Text = StringResources.btnDeleteFrm;
            btnUpload.Text = StringResources.btnUpload;
            grpModify.Text = StringResources.groupBoxModify;
            btnBack.Text = StringResources.buttonExit;
            btnInsertSessions.Text = StringResources.btnAccessSessions;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelect = new OpenFileDialog();
            ofdSelect.Filter = "Imagenes|*.jpg; *.png"; // Imagenes --> Leyenda|Filtrar solo por estas extensiones 
            ofdSelect.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Directorio donde cogemos las imágenes
            ofdSelect.Title = "Seleccionar imagen";

            if (ofdSelect.ShowDialog() == DialogResult.OK)
            {
                pibImage.Image = Image.FromFile(ofdSelect.FileName); // Agregar el archivo seleccionado y mostrarlo en el cuadro.
            }
        }

        #region Cargar Valores
        private void SetFilmsIdentifyingValues()
        {
            foreach (var values in Film.GetIdentifyingInfo())
            {
                cmbFilmsIds.Items.Add(values.id);
                cmbFilms.Items.Add(values.name);
            }
        }

        private void UpdateInputFields(Film film)
        {
            cmbFilmsIds.Text = film.Id.ToString();
            cmbFilms.Text = film.Name;
            pibImage.Image = film.Cover;
            rtbSynopsis.Text = film.Synopsis;
            nudMinAge.Value = film.MinAge;
            dtpHour.Text = film.Duration.ToString();
            txtPrice.Text = film.Price.ToString();
            chbPremiering.Checked = film.Premiering;
            chbNextPremiering.Checked = film.NextPremiering;
            cmbGenre1.Text = film.Genres[0];
            cmbGenre2.Text = film.Genres[1];
        }

        private void cmbFilmsIds_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateInputFields(Film.InfoFilm(Convert.ToInt32(cmbFilmsIds.Text)));
        }

        private void cmbFilms_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateInputFields(Film.InfoFilm(cmbFilms.Text));
        }
        #endregion

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
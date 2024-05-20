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

            LoadListMovies();

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
        private void btnModify_Click(object sender, EventArgs e)
        {
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
                    TimeSpan.Parse(txtDuration.Text),
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
            txtDuration.Text = film.Duration.ToString();
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

        private void CleanData()
        {
            cmbFilms.Text = string.Empty;
            cmbFilmsIds.Text = string.Empty;
            rtbSynopsis.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtPrice.Text = string.Empty;
            nudMinAge.Value = 0;
            cmbGenre1.Text = string.Empty;
            cmbGenre2.Text = string.Empty;
            chbPremiering.Checked = false;
            chbNextPremiering.Checked = false;
        }
    }
}
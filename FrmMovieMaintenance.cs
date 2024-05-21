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
    public partial class FrmMovieMaintenance : Form
    {
        public FrmMovieMaintenance()
        {
            InitializeComponent();
            grpClock.BackColor = Color.FromArgb(168, 228, 116);
            grpMaintenance.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void FrmMovieMaintenance_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Start();

            LoadListMovies();
            ApplyLanguage();

            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtFilm.Focus();

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string[] genres = new string[]
                {
                    cmbGenre1.Text,
                    cmbGenre2.Text
                };

                Film film = new Film(
                    txtFilm.Text,
                    rtbSynopsis.Text,
                    pibImage.Image,
                    TimeSpan.Parse(txtDuration.Text),
                    (int)nudMinAge.Value,
                    Convert.ToDouble(txtPrice.Text),
                    genres,
                    chbPremiering.Checked,
                    chbNextPremiering.Checked
                );

                film.Create();
                LoadListMovies();
                CleanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LoadListMovies()
        {
            dgvFilms.DataSource = Film.ObtainAll();
        }

        private void CleanData()
        {
            txtFilm.Text = string.Empty;
            rtbSynopsis.Text = string.Empty;
            txtDuration.Text = string.Empty;
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
            btnInsert.Text = StringResources.btnInsert;
            btnModifyFrm.Text = StringResources.btnModifyFrm;
            btnDeleteFrm.Text = StringResources.btnDeleteFrm;
            btnUpload.Text = StringResources.btnUpload;
        }


        #region Diseño de interface
        private void grpMaintenance_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpMaintenance.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void grpClock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpClock.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void pibImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pibImage.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        #endregion

        #region Acceso a formularios de acceso
        private void btnModifyFrm_Click(object sender, EventArgs e)
        {
            FrmMovieModify frmMovieModify = new FrmMovieModify();
            frmMovieModify.Show();
            this.Close();
        }

        private void btnDeleteFrm_Click(object sender, EventArgs e)
        {
            FrmMovieDelete frmMovieDelete = new FrmMovieDelete();
            frmMovieDelete.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }
        #endregion
    }
}
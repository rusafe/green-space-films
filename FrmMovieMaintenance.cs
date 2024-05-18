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
    }
}

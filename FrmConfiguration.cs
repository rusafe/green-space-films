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
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {

            timer1.Start();
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            user.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostrar un MessageBox de confirmación antes de guardar 
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario elige "Sí", cerrar la aplicación
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount account = new FrmAccount();
            account.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;

            lblHora.Text = horaActual.ToString("HH:mm:ss");
        }

        //private void ApplyNightMode()
        //{
        //    // Aplicar colores para el modo nocturno
        //    BackColor = Color.FromArgb(30, 30, 30);
        //    ForeColor = Color.White;
        //}

        //private void ApplyDayMode()
        //{
        //    // Aplicar colores para el modo diurno
        //    BackColor = Color.White;
        //    ForeColor = Color.Black;
        //}



        //private void btnDayMode_Click_1(object sender, EventArgs e)
        //{
        //    ApplyDayMode(); // Aplicar modo dia
        //}

        //private void btnNightMode_Click(object sender, EventArgs e)
        //{
        //    ApplyNightMode(); // Aplicar modo noche
        //}
    }
}

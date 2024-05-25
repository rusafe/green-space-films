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
    public partial class FrmChangeUsername : Form
    {
        public FrmChangeUsername()
        {
            InitializeComponent();
        }

        private void FrmChangeUsername_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            if (!ThemeMode.Light)
            {
                this.BackColor = Color.FromArgb(32, 146, 14);
            }
            ApplyLanguages();
        }

        private void ApplyLanguages()
        {
            btnChangeName.Text = StringResources.buttonChangeName;
            lblNewUsername.Text = StringResources.labelNewUsername;
        }

        private void btnNewUsername_Click(object sender, EventArgs e)
        {
           User.ChangeUsername(UserSession.Username, txtNewUsername.Text);
            MessageBox.Show("Nombre de usuario cambiado con éxito, procediendo con el cierre de sesión.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
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
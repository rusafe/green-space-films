using MySqlX.XDevAPI;
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
    public partial class FrmAdmin : Form
    {

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
            ApplyTheme();

            this.ActiveControl = btnAdmin;
            btnAdmin.Focus();
        }

        private void ErrorValidation(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void ApplyLanguage()
        {
            btnUser.Text = StringResources.labelUser;
            btnAdmin.Text = StringResources.buttonAdmin;
            btnAccount.Text = StringResources.buttonAccount;
            lblMailUser.Text = StringResources.labelUser;
            lblPassword.Text = StringResources.labelPassword;
            linklblForgotPass.Text = StringResources.labelForgottenPassword;
            btnLogin.Text = StringResources.buttonLogin;
            btnExit.Text = StringResources.buttonExit;
        }
        
        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnAdmin.BackColor = Color.FromArgb(168, 228, 116);
                btnAccount.BackColor = Color.FromArgb(176, 164, 180);
                grpBoxAdmin.BackColor = Color.FromArgb(168, 228, 116);
            }
            else
            {
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnAdmin.BackColor = Color.FromArgb(168, 228, 116);
                btnAccount.BackColor = Color.FromArgb(176, 164, 180);
                grpBoxAdmin.BackColor = Color.FromArgb(176, 164, 180);
                this.BackColor = Color.FromArgb(32, 146, 14);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User userInfo = new User();
                FrmAccount frm = new FrmAccount();

                userInfo = User.InfoUser(UserSession.Username);
                string username = UserSession.Username;

                if (User.ExistUser(username))
                {
                    if (User.IsAdministrator(txtUser.Text))
                    {
                        if (User.CheckPassword(username, UserSession.Password))
                        {
                            frm.Close();
                            this.Close();
                            FrmMovieMaintenance frmMaintenance = new FrmMovieMaintenance();
                            frmMaintenance.Show();
                        }
                        else
                        {
                            ErrorValidation("Contraseña incorrecta!");
                        }
                    }
                    else
                    {
                        ErrorValidation("La cuenta proporcionada no tiene permisos de administración.");
                    }
                }
                else
                {
                    ErrorValidation("Usuario no existente en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #region Acceso a formularios de configuración
        private void btnUser_Click_1(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Close();
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
            Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
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
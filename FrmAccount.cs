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
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            btnAccount.Focus();
        }

        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnAdmin.BackColor = Color.FromArgb(176, 164, 180);
                btnAccount.BackColor = Color.FromArgb(168, 228, 116);
            }
            else
            {
                btnUser.BackColor = Color.FromArgb(176, 164, 180);
                btnAdmin.BackColor = Color.FromArgb(176, 164, 180);
                btnAccount.BackColor = Color.FromArgb(168, 228, 116);
                this.BackColor = Color.FromArgb(32, 146, 14);
            }
        }

        private void ApplyLanguage()
        {
            btnUser.Text = StringResources.labelUser;
            btnAdmin.Text = StringResources.buttonAdmin;
            btnAccount.Text = StringResources.buttonAccount;
            btnExit.Text = StringResources.buttonExit;
            btnDeleteAccount.Text = StringResources.buttonDeleteAccount;
            lblDeleteUser.Text = StringResources.labelMailAssociated;
            grpSwitchNightDay.Text = StringResources.grpSwitch;
            btnPredet.Text = StringResources.buttonDefault;
            lblChangeLanguage.Text = StringResources.labelChangeLanguage;
        }


        private void pibLightMode_Click(object sender, EventArgs e)
        {
            ThemeMode.UseThemeLight();
            if (ThemeMode.Light)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void pibDarkMode_Click(object sender, EventArgs e)
        {
            ThemeMode.UseThemeDark();
            if (ThemeMode.Light == false)
            {
                this.BackColor = Color.FromArgb(32, 146, 14);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
        }
        
        #region Acceder a formularios de Configuración
        private void btnAccount_Click(object sender, EventArgs e)
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
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Close();
        }
        #endregion
    }
}
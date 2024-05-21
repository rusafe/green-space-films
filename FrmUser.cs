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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
            btnUser.BackColor = Color.FromArgb(168, 228, 116);
            btnAdmin.BackColor = Color.FromArgb(176, 164, 180);
            btnAccount.BackColor = Color.FromArgb(176, 164, 180);
            pictBoxPhotoPerfil.BackColor = Color.FromArgb(176, 164, 180);
            btnUser.Focus();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            btnUser.Text = StringResources.labelUser;
            btnAdmin.Text = StringResources.buttonAdmin;
            btnAccount.Text = StringResources.buttonAccount;
            lblNameUser.Text = StringResources.labelNameUser;
            btnChangeName.Text = StringResources.buttonChangeName;
            btnChangePhoto.Text = StringResources.buttonChangePhoto;
            lblMailAssociated.Text = StringResources.labelMailAssociated;
            btnChangePassword.Text = StringResources.buttonChangePassword;
            btnExit.Text = StringResources.buttonExit;
        }

        #region Acceso formularios configuración
        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Close();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmFilms frmFilms = new FrmFilms();
            frmFilms.Show();
        }
        #endregion
    }
}
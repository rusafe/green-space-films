using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        private void FrmRecoverPassword_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 228, 116);
            grpRecover.BackColor = Color.FromArgb(176, 164, 180);

            txtUsername.Focus();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            User user = new User();
            Mail password = new Mail();

            try
            {
                user.Username = txtUsername.Text;
                if (User.ExistUser(user.Username))
                {
                    password.RecoverPassword(user.Username);
                    MessageBox.Show("Contraseña generada con éxito.", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenLogin();
                } else
                {
                    MessageBox.Show("Usuario no existente en la base de datos.", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUsername.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }
        private void OpenLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
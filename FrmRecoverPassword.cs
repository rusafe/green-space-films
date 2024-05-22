using ProyectoGreenSpace.LangResources;
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
            ApplyTheme();
        }
        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                this.BackColor = Color.FromArgb(168, 228, 116);
                grpRecover.BackColor = Color.FromArgb(176, 164, 180);
            } else
            {
                this.BackColor = Color.FromArgb(176, 164, 180);
                grpRecover.BackColor = Color.FromArgb(32, 146, 14);
                btnLink.BackColor = Color.FromArgb(168, 228, 116);
            }
        }

        private void ApplyLanguage()
        {
            rtbInformation.Text = StringResources.rtbInfo;
            btnLink.Text = StringResources.buttonLink;
        }

        private void FrmRecoverPassword_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            txtUsername.Focus();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            User user = new User();
            Mail password = new Mail();

            try
            {
                user.Username = txtUsername.Text;
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Introduce un nombre de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (User.ExistUser(user.Username))
                {
                    password.RecoverPassword(user.Username);
                    MessageBox.Show("Contraseña generada con éxito.", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenLogin();
                }
                else
                {
                    MessageBox.Show("Usuario no existente en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void grpRecover_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpRecover.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
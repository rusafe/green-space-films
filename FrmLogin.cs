using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.LangResources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void AplicarIdioma()
        {
            lblUsername.Text = StringResources.labelUser;
            lblPassword.Text = StringResources.labelPassword;
            lkllblRecoverPassword.Text = StringResources.labelForgottenPassword;
            btnLogin.Text = StringResources.buttonLogin;
            lblInfoRegister.Text = StringResources.lblQuestionRegister;
            lklblRegister.Text = StringResources.linkRegister;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 228, 116);
            btnLogin.BackColor = Color.FromArgb(76, 80, 144);
            grpLogin.BackColor = Color.FromArgb(176, 164, 180);

            AplicarIdioma();

            txtUsername.Focus();
        }

        private void pibSpanish_Click(object sender, EventArgs e)
        {
            Language.LanguageSpanish();
            AplicarIdioma();
        }

        private void pibBritish_Click(object sender, EventArgs e)
        {
            Language.LanguageBritish();
            AplicarIdioma();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            try
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;

                Controller control = new Controller();
                string respuesta = control.ControllerLogin(user);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bienvenido/a Green Space Films!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FrmFilms frmFilms = new FrmFilms();
                    frmFilms.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }

        private void lkllblRecoverPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRecoverPassword fromRecover = new FrmRecoverPassword();
            fromRecover.Show();
        }

        #region Diseño de interface
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.SkyBlue;
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.SkyBlue;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }
        private void grpLogin_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpLogin.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpLogin.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        #endregion
    }
}
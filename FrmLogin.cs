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
            ApplyTheme();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
            txtUsername.Focus();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (ThemeMode.Light == true)
            {
                this.BackColor = Color.FromArgb(168, 228, 116);
                btnLogin.BackColor = Color.FromArgb(76, 80, 144);
                grpLogin.BackColor = Color.FromArgb(176, 164, 180);
            }
            else
            {
                this.BackColor = Color.FromArgb(176, 164, 180);
                btnLogin.BackColor = Color.FromArgb(168, 228, 116);
                grpLogin.BackColor = Color.FromArgb(32, 146, 14);
                lklblRegister.LinkColor = Color.FromArgb(255, 255, 255);
                lkllblRecoverPassword.LinkColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void ApplyLanguage()
        {
            lblUsername.Text = StringResources.labelUser;
            lblPassword.Text = StringResources.labelPassword;
            lkllblRecoverPassword.Text = StringResources.labelForgottenPassword;
            btnLogin.Text = StringResources.buttonLogin;
            lblInfoRegister.Text = StringResources.lblQuestionRegister;
            lklblRegister.Text = StringResources.linkRegister;
        }

        private void pibSpanish_Click(object sender, EventArgs e)
        {
            Language.LanguageSpanish();
            ApplyLanguage();
        }

        private void pibBritish_Click(object sender, EventArgs e)
        {
            Language.LanguageBritish();
            ApplyLanguage();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
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
            } else
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
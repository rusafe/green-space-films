using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoGreenSpace.LangResources;
using System.Globalization;
using System.Threading;
using ProyectoGreenSpace.Classes;

namespace ProyectoGreenSpace
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyLanguage()
        {
            lblUsername.Text = StringResources.labelUser;
            lblMail.Text = StringResources.labelMail;
            lblPassword.Text = StringResources.labelPassword;
            lblRepeat.Text = StringResources.labelRepeatPassword;
            btnUpload.Text = StringResources.buttonUpload;
            btnRegister.Text = StringResources.buttonRegister;
            lklblLogin.Text = StringResources.linkLogin;
        }
        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                this.BackColor = Color.FromArgb(168, 228, 116);
                btnRegister.BackColor = Color.FromArgb(76, 80, 144);
                grpRegister.BackColor = Color.FromArgb(176, 164, 180);
            }
            else
            {
                this.BackColor = Color.FromArgb(176, 164, 180);
                btnRegister.BackColor = Color.FromArgb(168, 228, 116);
                grpRegister.BackColor = Color.FromArgb(32, 146, 14);
                lklblLogin.LinkColor = Color.FromArgb(255, 255, 255);
            }

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
            txtUsername.Focus();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (ValidarDatos())
            {
                try
                {
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    user.RepeatPassword = txtRepeat.Text;
                    user.Mail = txtMail.Text;

                    Controller control = new Controller();
                    string answer = control.ControllerRegister(user);

                    if (answer.Length > 0)
                    {
                        MessageBox.Show(answer, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Enviando código de verificación, revise su correo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mail sendMail = new Mail();
                        if (ValidarDatos())
                        {
                            int code = sendMail.SendVerificationCode("floadm123@gmail.com", "AdminFlo123", user.Mail);
                            if (code != -1)
                            {
                                CleanData();
                                FrmInsertCode frmInsertCode = new FrmInsertCode(code);
                                frmInsertCode.Show();
                            }
                            else
                            {
                                MessageBox.Show("Código no enviado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessLogin();
        }

        /// <summary>
        /// Eliminar los datos de los campos.
        /// </summary>
        private void CleanData()
        {
            txtUsername.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRepeat.Text = string.Empty;
        }

        /// <summary>
        /// Acceder al inicio de sesión y ocultar el menú de registro.
        /// </summary>
        private void AccessLogin()
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Hide();
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsername, "Introduzca un nombre de usuario.");
            }
            else if (String.IsNullOrEmpty(txtMail.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMail, "Introduzca una dirección de correo electrónico.");
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Introduzca una contraseña.");
            }
            else if (String.IsNullOrEmpty(txtRepeat.Text))
            {
                ok = false;
                errorProvider1.SetError(txtRepeat, "Introduzca de nuevo la contraseá-");
            }
            return ok;
        }

        #region Diseño de interface

        private void grpRegister_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpRegister.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnRegister_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnRegister.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pibImage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pibImage.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.SkyBlue;
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            txtMail.BackColor = Color.SkyBlue;
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            txtMail.BackColor = Color.White;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.SkyBlue;
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }
        private void txtRepeat_Enter(object sender, EventArgs e)
        {
            txtRepeat.BackColor = Color.SkyBlue;
        }

        private void txtRepeat_Leave(object sender, EventArgs e)
        {
            txtRepeat.BackColor = Color.White;
        }
        #endregion

        #region Cargar foto usuario
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png"; // Imagenes --> Leyenda|Filtrar solo por estas extensiones 
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Directorio donde cogemos las imágenes
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pibImage.Image = Image.FromFile(ofdSeleccionar.FileName); // Agregar el archivo seleccionado y mostrarlo en el cuadro.
            }
        }
        #endregion

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
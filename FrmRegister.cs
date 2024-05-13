using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmRegister : Form
    {
        ConnectionBD bdata = new ConnectionBD();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 228, 116);
            btnRegister.BackColor = Color.FromArgb(76, 80, 144);
            grpRegister.BackColor = Color.FromArgb(176, 164, 180);

            txtUsername.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (ValidarDatos())
            {
                try
                {
                    if (bdata.AbrirConexion())
                    {
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;
                        user.RepeatPassword = txtRepeat.Text;
                        user.Mail = txtMail.Text;

                        Controller control = new Controller();
                        string respuesta = control.ControllerRegister(bdata.Connection, user);

                        if (respuesta.Length > 0)
                        {
                            MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Mail enviarMail = new Mail();
                            if (ValidarDatos())
                            {
                                int code = enviarMail.Enviar("floadm123@gmail.com", "AdminFlo123", user.Mail);
                                if (code != -1)
                                {
                                    LimpiarDatos();
                                    FrmInsertCode frmInsertCode = new FrmInsertCode(code);
                                    frmInsertCode.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Código no enviado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    bdata.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    bdata.CerrarConexion();
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
        private void LimpiarDatos()
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
        private void btnCargarFoto_Click(object sender, EventArgs e)
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
    }
}
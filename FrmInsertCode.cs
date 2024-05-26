using Microsoft.VisualBasic.ApplicationServices;
using ProyectoGreenSpace.LangResources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmInsertCode : Form
    {
        int verificationCode;
        User user = new User();

        public FrmInsertCode(string username, string password, string repeatPassword, string mail, Image pfp,int code)
        {
            InitializeComponent();
            user.Username = username;
            user.Password = password;
            user.RepeatPassword = repeatPassword;
            user.Mail = mail;
            user.Pfp = pfp;

            verificationCode = code;
            ApplyTheme();
        }

        private void FrmInsertCode_Load(object sender, EventArgs e)
        {
            mtbDigit1.Mask = "0";
            mtbDigit2.Mask = "0";
            mtbDigit3.Mask = "0";
            mtbDigit4.Mask = "0";
            mtbDigit5.Mask = "0";
            mtbDigit6.Mask = "0";

            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);

            ApplyLanguage();
            mtbDigit1.Focus();
        }

        private void ApplyLanguage()
        {
            btnSend.Text = StringResources.buttonSend;
        }

        private void ApplyTheme()
        {
            if (ThemeMode.Light)
            {
                this.BackColor = Color.FromArgb(168, 228, 116);
                btnSend.BackColor = Color.FromArgb(76, 80, 144);
            }
            else
            {
                this.BackColor = Color.FromArgb(32, 146, 14);
                btnSend.BackColor = Color.FromArgb(168, 228, 116);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string concatenatedCode = mtbDigit1.Text + mtbDigit2.Text + mtbDigit3.Text + mtbDigit4.Text + mtbDigit5.Text + mtbDigit6.Text;
            int obtainCode = Convert.ToInt32(concatenatedCode);
            
            if (verificationCode == obtainCode)
            {
                Controller control = new Controller();
                string answer = control.ControllerRegister(user);

                if (answer.Length > 0)
                {
                    MessageBox.Show(answer, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Verificación realizada con éxito.", "VERIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El código de verificación no coincide.", "VERIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtbDigit1_TextChanged(object sender, EventArgs e)
        {
            mtbDigit2.Focus();
        }

        private void mtbDigit2_TextChanged(object sender, EventArgs e)
        {
            mtbDigit3.Focus();
        }

        private void mtbDigit3_TextChanged(object sender, EventArgs e)
        {
            mtbDigit4.Focus();
        }

        private void mtbDigit4_TextChanged(object sender, EventArgs e)
        {
            mtbDigit5.Focus();
        }

        private void mtbDigit5_TextChanged(object sender, EventArgs e)
        {
            mtbDigit6.Focus();
        }

        private void mtbDigit6_TextChanged(object sender, EventArgs e)
        {
            btnSend.Focus();
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
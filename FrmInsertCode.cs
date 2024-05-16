using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmInsertCode : Form
    {
        int verificationCode;
        public FrmInsertCode(int code)
        {
            InitializeComponent();
            verificationCode = code;
        }

        private void FrmInsertCode_Load(object sender, EventArgs e)
        {
            mtbDigit1.Mask = "0";
            mtbDigit2.Mask = "0";
            mtbDigit3.Mask = "0";
            mtbDigit4.Mask = "0";
            mtbDigit5.Mask = "0";
            mtbDigit6.Mask = "0";

            this.BackColor = Color.FromArgb(168, 228, 116);
            btnSend.BackColor = Color.FromArgb(76, 80, 144);

            mtbDigit1.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string concatenatedCode = mtbDigit1.Text + mtbDigit2.Text + mtbDigit3.Text + mtbDigit4.Text + mtbDigit5.Text + mtbDigit6.Text;
            int obtainCode = Convert.ToInt32(concatenatedCode);

            if (verificationCode == obtainCode)
            {
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

        private void mtbDigit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDigit2.Text == "_")
            {
                mtbDigit1.Focus();
            }
        }

        private void mtbDigit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDigit3.Text == "_")
            {
                mtbDigit2.Focus();
            }
        }

        private void mtbDigit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDigit4.Text == "_")
            {
                mtbDigit3.Focus();
            }
        }

        private void mtbDigit5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDigit5.Text == "_")
            {
                mtbDigit4.Focus();
            }
        }

        private void mtbDigit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDigit6.Text == "_")
            {
                mtbDigit5.Focus();
            }
        }
    }
}
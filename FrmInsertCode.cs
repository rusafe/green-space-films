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
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmRecoverPassword : Form
    {
        ConnectionBD bdata = new ConnectionBD();

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
                if (bdata.OpenConnection())
                {
                    user.Username = txtUsername.Text;
                    password.RecoverPassword(bdata.Connection, user.Username);

                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();
                    this.Close();
                }
                bdata.OpenConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                bdata.CloseConnection();
            }
        }
    }
}
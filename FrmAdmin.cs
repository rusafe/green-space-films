using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmAdmin : Form
    {

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User userInfo = new User();
                FrmAccount frm = new FrmAccount();

                userInfo = User.InfoUser(UserSession.Username);
                string username = UserSession.Username;

                if (User.ExistUser(username))
                {
                    if (User.IsAdministrator(username))
                    {
                        if (User.CheckPassword(username, UserSession.Password))
                        {
                            frm.Close();
                            this.Close();
                            FrmMovieMaintenance frmMaintenance = new FrmMovieMaintenance();
                            frmMaintenance.Show();
                        } else
                        {
                            ErrorValidation("Contraseña incorrecta!");
                        }
                    }
                    else
                    {
                        ErrorValidation("La cuenta proporcionada no tiene permisos de administración.");
                    }
                }
                else
                {
                    ErrorValidation("Usuario no existente en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ErrorValidation(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}

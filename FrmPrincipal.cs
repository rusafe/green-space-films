using System;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            txtUsername.Text = Session.Username;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
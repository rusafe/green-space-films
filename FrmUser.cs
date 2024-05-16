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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAdmin_Click(object sender, System.EventArgs e)
        {
            FrmAdmin form3 = new FrmAdmin();
            form3.ShowDialog();

        }

        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            FrmAccount form4 = new FrmAccount();
            form4.ShowDialog();
        }
    }
}

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
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin for3 = new FrmAdmin();
            for3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pibLightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void pibDarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 146, 14);
        }
    }
}
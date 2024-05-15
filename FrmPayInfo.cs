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
    public partial class FrmPayInfo : Form
    {
        public FrmPayInfo()
        {
            InitializeComponent();
            grpInfo.BackColor = Color.FromArgb(168, 228, 116);
            txtSeating.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}

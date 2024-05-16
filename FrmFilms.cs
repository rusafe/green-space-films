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
    public partial class FrmFilms : Form
    {
        bool sidebarExpand;
        public FrmFilms()
        {
            InitializeComponent();

            grbMovie1.BackColor = Color.FromArgb(176, 164, 180);
            grbMovie2.BackColor = Color.FromArgb(176, 164, 180);
            grbMovie3.BackColor = Color.FromArgb(176, 164, 180);
            grbMovie4.BackColor = Color.FromArgb(176, 164, 180);
            grbMovie5.BackColor = Color.FromArgb(168, 228, 116);
            grbMovie6.BackColor = Color.FromArgb(168, 228, 116);
            grbMovie7.BackColor = Color.FromArgb(168, 228, 116);
            grbMovie8.BackColor = Color.FromArgb(168, 228, 116);

            pcbMovie1.BackColor = Color.FromArgb(168, 228, 116);
            pcbMovie2.BackColor = Color.FromArgb(168, 228, 116);
            pcbMovie3.BackColor = Color.FromArgb(168, 228, 116);
            pcbMovie4.BackColor = Color.FromArgb(168, 228, 116);
            pcbMovie5.BackColor = Color.FromArgb(176, 164, 180);
            pcbMovie6.BackColor = Color.FromArgb(176, 164, 180);
            pcbMovie7.BackColor = Color.FromArgb(176, 164, 180);
            pcbMovie8.BackColor = Color.FromArgb(176, 164, 180);

            sidebar.BackColor = Color.FromArgb(168, 228, 116);
            btnMenu.BackColor = Color.FromArgb(168, 228, 116);
            btnTicketOffice.BackColor = Color.FromArgb(168, 228, 116);
            btnReviewTickets.BackColor = Color.FromArgb(168, 228, 116);
            btnReviews.BackColor = Color.FromArgb(168, 228, 116);
            btnUser.BackColor = Color.FromArgb(168, 228, 116);
            btnSettings.BackColor = Color.FromArgb(168, 228, 116);
            btnDeveloping.BackColor = Color.FromArgb(168, 228, 116);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_MouseClick_1(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    sidebarTimer.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    sidebarTimer.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.ShowDialog();
        }

        private void grbMovie1_Enter(object sender, EventArgs e)
        {
            FrmFilms ndknd = new FrmFilms();

        }
    }
}

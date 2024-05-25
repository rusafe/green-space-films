using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmSelectSeats : Form
    {
        private Seats seats;
        private string filmName;

        public FrmSelectSeats(int sessionId, string filmName)
        {
            InitializeComponent();

            this.seats = new Seats(sessionId);
            this.filmName = filmName;
            LoadSeatsPictures();
        }

        private void LoadSeatsPictures()
        {
            for (int y = 0; y < seats.SeatsArray.GetLength(0); y++)
            {
                for (int x = 0; x < seats.SeatsArray.GetLength(1); x++)
                {
                    PictureBox pcbSeat = (PictureBox)this.Controls.Find($"seatPicture{y}{x + 1}", true)[0];

                    pcbSeat.Image = seats.SeatOccupied(y, x) ? Resources.seat_red : Resources.seat_green;
                }
            }
        }

        private void FrmSelectSeats_Load(object sender, EventArgs e)
        {
            g2Bar.BackColor = Color.FromArgb(76, 80, 144);
            g2lblTitle.ForeColor = Color.FromArgb(168, 228, 116);
            pibSelects.BackColor = Color.FromArgb(168, 228, 116);
        }

        private void SeatClicked(int rowIndex, int colIndex)
        {
            Seat seat = seats.getSeat(rowIndex, colIndex);
            PictureBox pcbSeat = (PictureBox)this.Controls.Find($"seatPicture{rowIndex}{colIndex + 1}", true)[0];

            if (!seat.Occupied)
            {
                seat.ChangeSelectedStatus();

                lblSelected.Text = (Convert.ToInt32(lblSelected.Text) + (seat.Selected ? 1 : -1)).ToString();
            }

            if (seat.Occupied)
            {
                pcbSeat.Image = Resources.seat_red;
            }
            else if (seat.Selected)
            {
                pcbSeat.Image = Resources.seat_blue;
            }
            else
            {
                pcbSeat.Image = Resources.seat_green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPayInfo frmPayInfo = new FrmPayInfo(seats.SessionId, seats.CreateSeatsStatusImage(), seats.AmountSelected());
            frmPayInfo.Show();
            this.Close();
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

        private void seatPicture01_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 0);
        }

        private void seatPicture02_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 1);
        }

        private void seatPicture03_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 2);
        }

        private void seatPicture04_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 3);
        }

        private void seatPicture05_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 4);
        }

        private void seatPicture06_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 5);
        }

        private void seatPicture07_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 6);
        }

        private void seatPicture08_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 7);
        }

        private void seatPicture09_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 8);
        }

        private void seatPicture11_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 0);
        }

        private void seatPicture12_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 1);
        }

        private void seatPicture13_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 2);
        }

        private void seatPicture14_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 3);
        }

        private void seatPicture15_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 4);
        }

        private void seatPicture16_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 5);
        }

        private void seatPicture17_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 6);
        }

        private void seatPicture18_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 7);
        }

        private void seatPicture19_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 8);
        }

        private void seatPicture21_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 0);
        }

        private void seatPicture22_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 1);
        }

        private void seatPicture23_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 2);
        }

        private void seatPicture24_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 3);
        }

        private void seatPicture25_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 4);
        }

        private void seatPicture26_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 5);
        }

        private void seatPicture27_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 6);
        }

        private void seatPicture28_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 7);
        }

        private void seatPicture29_Click(object sender, EventArgs e)
        {
            SeatClicked(2, 8);
        }

        private void seatPicture31_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 0);
        }

        private void seatPicture32_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 1);
        }

        private void seatPicture33_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 2);
        }

        private void seatPicture34_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 3);
        }

        private void seatPicture35_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 4);
        }

        private void seatPicture36_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 5);
        }

        private void seatPicture37_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 6);
        }

        private void seatPicture38_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 7);
        }

        private void seatPicture39_Click(object sender, EventArgs e)
        {
            SeatClicked(3, 8);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMovieTheater frmMovieTheater = new FrmMovieTheater(filmName);
            frmMovieTheater.Show();
            this.Close();
        }
    }
}

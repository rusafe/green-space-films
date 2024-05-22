using ProyectoGreenSpace.Classes;
using ProyectoGreenSpace.Properties;
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
    public partial class FrmSelectSeats : Form
    {
        private Seats seats;

        public FrmSelectSeats(int sessionId)
        {
            InitializeComponent();

            this.seats = new Seats(sessionId);
            LoadSeatsPictures();
        }

        private void LoadSeatsPictures()
        {
            for (int i = 0; i < seats.SeatsArray.GetLength(0); i++)
            {
                for (int j = 0; j < seats.SeatsArray.GetLength(1); j++)
                {
                    PictureBox pcbSeat = (PictureBox)this.Controls.Find($"pictureBox{i}{j + 1}", true)[0];

                    pcbSeat.Image = seats.SeatOccupied(i, j) ? Resources.seat_red : Resources.seat_green;
                }
            }
        }

        private void SeatClicked(int rowIndex, int colIndex)
        {
            Seat seat = seats.getSeat(rowIndex, colIndex);
            PictureBox pcbSeat = (PictureBox)this.Controls.Find($"pictureBox{rowIndex}{colIndex + 1}", true)[0];

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SeatClicked(0, 3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SeatClicked(1, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seats.UploadSeatsStatus();
        }
    }
}

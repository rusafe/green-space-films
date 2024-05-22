using MySql.Data.MySqlClient;
using ProyectoGreenSpace.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGreenSpace.Classes
{
    internal class Seats
    {
        private Seat[,] seatsArray = new Seat[2, 4];
        private int sessionId;

        public Seat[,] SeatsArray { get { return seatsArray; } }

        public Seats(int sessionId)
        {
            this.sessionId = sessionId;
            LoadSeatsArray();
        }

        public Seat getSeat(int rowIndex, int colIndex)
        {
            return seatsArray[rowIndex, colIndex];
        }

        public void UploadSeatsStatus()
        {
            string query = "UPDATE sessions SET seats_status = @seatsStatus WHERE id = @sessionId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@seatsStatus", ImagesDB.BitmapToBytes(CreateSeatsStatusImage()));

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        public bool SeatOccupied(int seatRow, int seatCol)
        {
            return seatsArray[seatRow, seatCol].Occupied;
        }

        private void LoadSeatsArray()
        {
            Bitmap seatsStatus = ObtainSessionImage();

            for (int i = 0; i < seatsStatus.Height; i++)
            {
                for (int j = 0; j < seatsStatus.Width; j++)
                {
                    Color seatColor = seatsStatus.GetPixel(j, i);

                    seatsArray[i, j] = new Seat(seatColor.R == 255);
                }
            }
        }

        private Bitmap ObtainSessionImage()
        {
            string query = "SELECT seats_status FROM sessions WHERE id = @sessionId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@sessionId", sessionId);

            ConnectionBD.OpenConnection();

            Bitmap seatsStatus = ImagesDB.BytesToBitmap((byte[])command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return seatsStatus;
        }

        private Bitmap CreateSeatsStatusImage()
        {
            Bitmap seatsStatus = new Bitmap(4, 2);

            for (int i = 0; i < seatsArray.GetLength(0); i++)
            {
                for (int j = 0; j < seatsArray.GetLength(1); j++)
                {
                    Color seatColor = seatsArray[i, j].Selected || seatsArray[i, j].Occupied ? Color.Red : Color.Green;

                    seatsStatus.SetPixel(j, i, seatColor);
                }
            }

            return seatsStatus;
        }
    }
}

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
        public const int SEATS_PER_SESSION = 8;
        public const int SEATS_ROW = 2;
        public const int SEATS_COL = 4;

        private Seat[,] seatsArray = new Seat[SEATS_ROW, SEATS_COL];
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

        public static Bitmap CreateDefaultSeatsStatus()
        {
            Bitmap seatsStatus = new Bitmap(SEATS_ROW, SEATS_COL);

            for (int i = 0; i < seatsStatus.Height; i++)
            {
                for (int j = 0; j < seatsStatus.Width; j++)
                {
                    seatsStatus.SetPixel(j, i, Color.Green);
                }
            }

            return seatsStatus;
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
            Bitmap seatsStatus = new Bitmap(SEATS_ROW, SEATS_COL);

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

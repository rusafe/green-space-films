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
        public int SessionId { get { return sessionId; } }

        public Seats(int sessionId)
        {
            this.sessionId = sessionId;
            LoadSeatsArray();
        }

        public Seats(int sessionId, Seat[,] seatsArray)
        {
            this.sessionId = sessionId;
            this.seatsArray = seatsArray;
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

        public int AmountSelected()
        {
            int amount = 0;

            foreach (Seat seat in seatsArray)
            {
                if (seat.Selected)
                {
                    amount++;
                }
            }

            return amount;
        }

        public Bitmap CreateSeatsStatusImage()
        {
            Bitmap seatsStatus = new Bitmap(SEATS_COL, SEATS_ROW);

            for (int y = 0; y < seatsArray.GetLength(0); y++)
            {
                for (int x = 0; x < seatsArray.GetLength(1); x++)
                {
                    Color seatColor = seatsArray[y, x].Selected || seatsArray[y, x].Occupied ? Color.Red : Color.Green;

                    seatsStatus.SetPixel(x, y, seatColor);
                }
            }

            return seatsStatus;
        }

        public static Bitmap CreateDefaultSeatsStatus()
        {
            Bitmap seatsStatus = new Bitmap(SEATS_COL, SEATS_ROW);

            for (int y = 0; y < seatsStatus.Height; y++)
            {
                for (int x = 0; x < seatsStatus.Width; x++)
                {
                    seatsStatus.SetPixel(x, y, Color.Green);
                }
            }

            return seatsStatus;
        }

        public static Seat[,] CreateSeatsArrayFromBitmap(Bitmap seatsStatus)
        {
            Seat[,] seats = new Seat[SEATS_ROW, SEATS_COL];

            for (int y = 0; y < seatsStatus.Height; y++)
            {
                for (int x = 0; x < seatsStatus.Width; x++)
                {
                    Color seatColor = seatsStatus.GetPixel(x, y);

                    seats[y, x] = new Seat(seatColor.R == 255);
                }
            }

            return seats;
        }

        private void LoadSeatsArray()
        {
            seatsArray = CreateSeatsArrayFromBitmap(ObtainSessionImage());
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
    }
}

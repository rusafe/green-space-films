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
        public const int SEATS_PER_SESSION = 36;
        public const int SEATS_ROW = 4;
        public const int SEATS_COL = 9;

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

        /// <summary>
        /// Obtiene el asiento en la posicion indicada
        /// </summary>
        /// <param name="rowIndex">Fila del asiento</param>
        /// <param name="colIndex">Columna del asiento</param>
        /// <returns>El asiento especificado</returns>
        public Seat getSeat(int rowIndex, int colIndex)
        {
            return seatsArray[rowIndex, colIndex];
        }

        /// <summary>
        /// Actualiza la base de datos con el estado actual de los asientos
        /// </summary>
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

        /// <summary>
        /// Obtiene si el asiento especificado esta ocupado
        /// </summary>
        /// <param name="seatRow">Fila del asiento</param>
        /// <param name="seatCol">Columna del asiento</param>
        /// <returns>Booleano</returns>
        public bool SeatOccupied(int seatRow, int seatCol)
        {
            return seatsArray[seatRow, seatCol].Occupied;
        }

        /// <summary>
        /// Obtiene la cantidad de asientos selecionados
        /// </summary>
        /// <returns>Cantidad de asientos selecionados</returns>
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

        /// <summary>
        /// Crea una imagen con la informacion de los asientos almacenada en el array multidimensional
        /// </summary>
        /// <returns>Imagen con la informacion de los asientos</returns>
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

        /// <summary>
        /// Crea la imagen por defecto con todos los asientos libres
        /// </summary>
        /// <returns>Imagen por defecto de los asientos</returns>
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

        /// <summary>
        /// Crea un array multidimensional que representa los asientos en base a una imagen
        /// </summary>
        /// <param name="seatsStatus">La imagen con el estado de los asientos</param>
        /// <returns>Un array multidimensional</returns>
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

        /// <summary>
        /// Carga el array multidimensional en base al estado de los asientos de la base de datos
        /// </summary>
        private void LoadSeatsArray()
        {
            seatsArray = CreateSeatsArrayFromBitmap(ObtainSessionImage());
        }

        /// <summary>
        /// Obtiene la imagen con el estado de los asientos de la base de datos
        /// </summary>
        /// <returns>Una imagen con el estado de los asientos</returns>
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

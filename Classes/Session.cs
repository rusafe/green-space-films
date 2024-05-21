using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Frame.Types;

namespace ProyectoGreenSpace.Classes
{
    internal class Session
    {
        public const int MAX_SESSIONS_PER_FILM = 5;

        private int id;
        private int filmId;
        private int roomId;
        private TimeSpan startHour;
        private int totalSeats;
        private int occupiedSeats;

        public TimeSpan StartHour { get { return startHour; } }
        public int TotalSeats { get { return totalSeats; } }
        public int OccupiedSeats { get { return occupiedSeats; } }

        public Session(int id, int filmId, int roomId, TimeSpan startHour, int totalSeats, int occupiedSeats)
        {
            this.id = id;
            this.filmId = filmId;
            this.roomId = roomId;
            this.startHour = startHour;
            this.totalSeats = totalSeats;
            this.occupiedSeats = occupiedSeats;
        }

        /// <summary>
        /// Obtiene la pelicula de la sesion
        /// </summary>
        /// <returns>Un objeto pelicula</returns>
        public Film getFilm()
        {
            return Film.InfoFilm(filmId);
        }

        /// <summary>
        /// Obtiene la sala de la sesion
        /// </summary>
        /// <returns>Un objeto sala</returns>
        public Room getRoom()
        {
            return Room.InfoRoom(roomId);
        }

        /// <summary>
        /// Obtain the number of free seats for the session
        /// </summary>
        /// <returns>Number of free seats</returns>
        public int FreeSeats()
        {
            return totalSeats - occupiedSeats;
        }

        /// <summary>
        /// Aumenta la cantidad de asientos ocupados de una sesión
        /// </summary>
        /// <param name="seats">Cantidad de asientos ocupados</param>
        public void OccupySeats(int seats)
        {
            string query = "UPDATE session SET occupied_seats = occupied_seats + @seats WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@seats", seats);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Obtain a list for all the sessions of a given film
        /// </summary>
        /// <param name="filmId">A film Id</param>
        /// <returns>A list with all the sessions</returns>
        public static List<Session> ObtainAllSessions(int filmId)
        {
            List<Session> sessions = new List<Session>();

            string query = "SELECT * FROM sessions WHERE filmId = @filmId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmId", filmId);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    sessions.Add(new Session(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetTimeSpan(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return sessions;
        }

        /// <summary>
        /// Obtain a list for all the sessions of a given film
        /// </summary>
        /// <param name="filmName">A film name</param>
        /// <returns>A list with all the sessions</returns>
        public static List<Session> ObtainAllSessions(string filmName)
        {
            List<Session> sessions = new List<Session>();

            string query = "SELECT * FROM sessions WHERE filmId IN (SELECT id FROM films WHERE name = @filmName)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmName", filmName);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    sessions.Add(new Session(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetTimeSpan(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return sessions;
        }

        public static int AmountSessions(int filmId)
        {
            string query = "SELECT COUNT(*) FROM sessions WHERE filmId = @filmId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmId", filmId);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }
    }
}

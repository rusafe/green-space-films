using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal class Session
    {
        private int id;
        private int filmId;
        private int roomId;
        private TimeSpan startHour;
        private int totalSeats;
        private int occupiedSeats;

        public TimeSpan StartHour { get { return startHour; } }

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
    }
}

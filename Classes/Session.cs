using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public int Id { get { return id; } }
        public int FilmId { get { return filmId; } }
        public int RoomId { get { return roomId; } }
        public TimeSpan StartHour { get { return startHour; } }
        public int TotalSeats { get { return totalSeats; } }
        public int OccupiedSeats { get { return occupiedSeats; } }

        public Session (int filmId, int roomId, TimeSpan startHour)
        {
            this.filmId = filmId;
            this.roomId = roomId;
            this.startHour = startHour;
        }

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
        /// Inserta la sesion en la base de datos
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO sessions (filmId, roomId, startHour, total_seats, occupied_seats, seats_status) VALUES (@filmId, @roomId, @startHour, @totalSeats, @occupiedSeats, @seatsStatus)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmId", filmId);
            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@startHour", startHour);
            command.Parameters.AddWithValue("@totalSeats", Seats.SEATS_PER_SESSION);
            command.Parameters.AddWithValue("@occupiedSeats", 0);
            command.Parameters.AddWithValue("@seatsStatus", ImagesDB.BitmapToBytes(Seats.CreateDefaultSeatsStatus()));

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Obtiene la sesion con el id especificado
        /// </summary>
        /// <param name="id">El id de la sesion</param>
        /// <returns>Un objeto sesion</returns>
        public static Session ObtainSession(int id)
        {
            string query = "SELECT * FROM sessions WHERE id = @id";
            
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Session session = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    session = new Session(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetTimeSpan(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return session;
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
            string query = "UPDATE sessions SET occupied_seats = occupied_seats + @seats WHERE id = @id";

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

        /// <summary>
        /// Obtiene la cantidad de sesiones para un pelicula
        /// </summary>
        /// <param name="filmId">Id de la pelicula</param>
        /// <returns>Cantidad de sesiones</returns>
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

        /// <summary>
        /// Reinicia todas las sesiones de la base de datos
        /// </summary>
        public static void RestartSessions()
        {
            string query = "UPDATE sessions SET seats_status = @seatsStatus";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("seatsStatus", ImagesDB.BitmapToBytes(Seats.CreateDefaultSeatsStatus()));

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }
    }
}

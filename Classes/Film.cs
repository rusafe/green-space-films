using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProyectoGreenSpace.Classes
{
    internal class Film
    {
        private int id;
        private string name;
        private string synopsis;
        private Image cover;
        private TimeSpan duration;
        private int minAge;
        private double price;
        private string[] genres;
        private bool premiering;
        private bool nextPremiering;

        public Film(int id, string name, string synopsis, Image cover, TimeSpan duration, int minAge, double price, string[] genres, bool premiering, bool nextPremiering)
        {
            this.id = id;
            this.name = name;
            this.synopsis = synopsis;
            this.cover = cover;
            this.duration = duration;
            this.minAge = minAge;
            this.price = price;
            this.genres = genres;
            this.premiering = premiering;
            this.nextPremiering = nextPremiering;
        }

        public double TotalScore()
        {
            string queryString = "SELECT AVG(score) FROM reviews WHERE fimlId = @film";

            ConnectionBD.OpenConnection();

            MySqlCommand command = new MySqlCommand(queryString, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@film", id);
            double score = Convert.ToDouble(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return score;
        }

        public static Film InfoFilm(int id)
        {
            string query = "SELECT * FROM films WHERE id LIKE @id";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Film film = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    film = new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        reader.GetString(7).Split(','),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return film;
        }

        public static List<Film> ObtainAllPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE premiering = 1";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    premiering.Add(new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        reader.GetString(7).Split(','),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        public static List<Film> ObtainAllNextPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE next_premiering = 1";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    premiering.Add(new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        reader.GetString(7).Split(','),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }
    }
}

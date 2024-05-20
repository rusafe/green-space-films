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

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Synopsis { get { return synopsis; } }
        public Image Cover { get { return cover; } }
        public TimeSpan Duration { get { return duration; } }
        public int MinAge { get { return minAge; } }
        public double Price { get { return price; } }
        public string[] Genres { get { return genres; } }
        public bool Premiering { get { return premiering; } }
        public bool NextPremiering { get { return nextPremiering; } }

        public Film(string name, string synopsis, Image cover, TimeSpan duration, int minAge, double price, string[] genres, bool premiering, bool nextPremiering)
        {
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

        #region Metodos de interfaz
        /// <summary>
        /// Gets all the identifying fields (id and name) of the films and return them as a list of tuples that contain the identifying information for each film
        /// </summary>
        /// <returns>List of tuples containing the film id and name</returns>
        public static List<(int id, string name)> GetIdentifyingInfo()
        {
            List<(int id, string name)> list = new List<(int id, string name)>();

            string query = "SELECT id, name FROM films";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    list.Add(
                        (
                            reader.GetInt32(0),
                            reader.GetString(1)
                        )
                    );
                }
            }

            ConnectionBD.CloseConnection();

            return list;
        }

        /// <summary>
        /// Inserts the Film into the Database
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO films (name, synopsis, cover, duration, minAge, price, genres, premiering, next_premiering) VALUES (@name, @synopsis, @cover, @duration, @minAge, @price, @genres, @premiering, @nextPremiering)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@synopsis", synopsis);
            command.Parameters.AddWithValue("@cover", ImagesDB.ImageToBytes(cover));
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@minAge", minAge);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@genres", GenresToString());
            command.Parameters.AddWithValue("@premiering", premiering);
            command.Parameters.AddWithValue("@nextPremiering", nextPremiering);

            ConnectionBD.OpenConnection();
            
            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Updates the Film with the Id attribute value with the info in its attributes
        /// </summary>
        public void Update()
        {
            string query = "UPDATE films SET name = @name, synopsis = @synopsis, cover = @cover, duration = @duration, minAge = @minAge, price = @price, genres = @genres, premiering = @premiering, next_premiering = @nextPremiering WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@synopsis", synopsis);
            command.Parameters.AddWithValue("@cover", ImagesDB.ImageToBytes(cover));
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@minAge", minAge);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@genres", GenresToString());
            command.Parameters.AddWithValue("@premiering", premiering);
            command.Parameters.AddWithValue("@nextPremiering", nextPremiering);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Deletes a Film from the Database
        /// </summary>
        /// <param name="id">The film Id</param>
        public static void Delete(int id)
        {
            string query = "DELETE FROM films WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        public static bool Exists(string name)
        {
            bool exists;
            
            string query = "SELECT id FROM films WHERE name LIKE @name";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                exists = reader.HasRows;
            }

            ConnectionBD.CloseConnection();

            return exists;
        }

        public double TotalScore()
        {
            string query = "SELECT AVG(score) FROM reviews WHERE fimlId = @film";

            ConnectionBD.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@film", id);
            double score = Convert.ToDouble(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return score;
        }

        public static Film InfoFilm(int id)
        {
            string query = "SELECT * FROM films WHERE id = @id";
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
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return film;
        }

        public static Film InfoFilm(string name)
        {
            string query = "SELECT * FROM films WHERE name = @name";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);

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
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return film;
        }

        public static List<Film> ObtainAll()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films";

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
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        public static int Amount()
        {
            string query = "SELECT COUNT(*) FROM films";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        public static List<Film> ObtainAllPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE premiering = '1'";

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
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        public static int AmountPremiering()
        {
            string query = "SELECT COUNT(*) FROM films WHERE premiering = @premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@premiering", true);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        public static List<Film> ObtainAllNextPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE next_premiering = '1'";

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
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        public static int AmountNextPremiering()
        {
            string query = "SELECT COUNT(*) FROM films WHERE next_premiering = @next_premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@next_premiering", true);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }
        #endregion

        #region Metodos de implementacion
        private string GenresToString()
        {
            string genresString = "";
            foreach (string genre in this.genres)
            {
                genresString += $"{genre},";
            }
            genresString = genresString.Remove(genresString.Length - 1, 1);

            return genresString;
        }

        private static string[] GenresStringToArray(string genresString)
        {
            return genresString.Split(',');
        }
        #endregion
    }
}

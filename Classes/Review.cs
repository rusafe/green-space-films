using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoGreenSpace.Classes
{
    internal class Review
    {
        private int id;
        private int userId;
        private int filmId;
        private string reviewMessage;
        private double score;
        private DateTime reviewDateTime;

        public string ReviewMessage { get { return reviewMessage; } }
        public double Score { get { return score; } }
        public DateTime ReviewDateTime { get { return reviewDateTime; } }

        public Review(int userId, int filmId, string reviewMessage, double score, DateTime reviewDateTime)
        {
            this.userId = userId;
            this.filmId = filmId;
            this.reviewMessage = reviewMessage;
            this.score = score;
            this.reviewDateTime = reviewDateTime;
        }

        public Review(int id, int userId, int filmId, string reviewMessage, double score, DateTime reviewDateTime)
        {
            this.id = id;
            this.userId = userId;
            this.filmId = filmId;
            this.reviewMessage = reviewMessage;
            this.score = score;
            this.reviewDateTime = reviewDateTime;
        }

        /// <summary>
        /// Obtiene el usuario de la reseña
        /// </summary>
        /// <returns>Un objeto usuario</returns>
        public User getUser()
        {
            return User.InfoUser(userId);
        }

        /// <summary>
        /// Obtiene la pelicula de la reseña
        /// </summary>
        /// <returns>Un objeto pelicula</returns>
        public Film getFilm()
        {
            return Film.InfoFilm(filmId);
        }

        /// <summary>
        /// Inserts the review into the database
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO reviews (userId, filmId, review_message, score, reviewDateTime) VALUES (@userId, @filmId, @reviewMessage, @score, @reviewDateTime)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@filmId", filmId);
            command.Parameters.AddWithValue("@reviewMessage", reviewMessage);
            command.Parameters.AddWithValue("@score", score);
            command.Parameters.AddWithValue("@reviewDateTime", reviewDateTime);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Obtiene todas las reseñas de la pelicula indicada
        /// </summary>
        /// <param name="filmId">El ID de la pelicula</param>
        /// <returns>Lista con las reseñas</returns>
        public static List<Review> ObtainReviews(int filmId)
        {
            List<Review> reviews = new List<Review>();

            string query = "SELECT * FROM reviews WHERE filmId = @filmId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmId", filmId);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    reviews.Add(new Review(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetDouble(4),
                        reader.GetDateTime(5)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return reviews;
        }

        /// <summary>
        /// Obtiene un máximo de reseñas de la pelicula indicada
        /// </summary>
        /// <param name="filmId">El ID de la pelicula</param>
        /// <param name="maxReviews">Cantidad máxima de reseñas</param>
        /// <returns>Lista con las reseñas</returns>
        public static List<Review> ObtainReviews(int filmId, int maxReviews)
        {
            List<Review> reviews = new List<Review>();

            string query = "SELECT * FROM reviews WHERE filmId = @filmId LIMIT @maxReviews";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@filmId", filmId);
            command.Parameters.AddWithValue("@limit", maxReviews);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    reviews.Add(new Review(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetDouble(4),
                        reader.GetDateTime(5)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return reviews;
        }

        public static List<Review> ObtainReviews(int? score, string filmName, string sortOrder, int maxReviews)
        {
            List<Review> reviews = new List<Review>();
            
            string scoreQuery = score is null ? "" : $"AND score = {score.Value}";
            string filmNameQuery = string.IsNullOrEmpty(filmName) ? "" : $"AND filmId = {Film.InfoFilm(filmName).Id}";
            string sortOrderQuery = ObtainSortOrderQuery(sortOrder);

            string query = $"SELECT * FROM reviews WHERE id > 0 {scoreQuery} {filmNameQuery} {sortOrderQuery} LIMIT @limit";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@limit", maxReviews);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    reviews.Add(new Review(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetDouble(4),
                        reader.GetDateTime(5)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return reviews;
        }

        private static string ObtainSortOrderQuery(string sortOrder)
        {
            switch (sortOrder)
            {
                case "Mas recientes":
                    return "ORDER BY reviewDateTime DESC";
                case "Menos recientes":
                    return "ORDER BY reviewDateTime ASC";
                case "Mas estrellas":
                    return "ORDER BY score DESC";
                case "Menos estrellas":
                    return "ORDER BY score ASC";
                default:
                    return null;
            }
        }
    }
}

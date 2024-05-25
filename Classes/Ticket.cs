using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoGreenSpace.Classes
{
    internal class Ticket
    {
        private int id;
        private int userId;
        private int filmId;
        private int roomId;
        private DateTime dateBought;
        private DateTime dateFilm;
        private TimeSpan hourFilm;
        private int quantity;
        private double individualPrice;
        private int discount;

        public DateTime DateBought { get { return dateBought; } }
        public DateTime DateFilm { get { return dateFilm; } }
        public TimeSpan HourFilm { get { return hourFilm; } }
        public int Quantity { get { return quantity; } }
        public double IndividualPrice { get { return individualPrice; } }
        public int Discount { get { return discount; } }

        public Ticket(int userId, int filmId, int roomId, DateTime dateBought, DateTime dateFilm, TimeSpan hourFilm, int quantity, double individualPrice, int discount)
        {
            this.userId = userId;
            this.filmId = filmId;
            this.roomId = roomId;
            this.dateBought = dateBought;
            this.dateFilm = dateFilm;
            this.hourFilm = hourFilm;
            this.quantity = quantity;
            this.individualPrice = individualPrice;
            this.discount = discount;
        }

        public Ticket(int id, int userId, int filmId, int roomId, DateTime dateBought, DateTime dateFilm, TimeSpan hourFilm, int quantity, double individualPrice, int discount)
        {
            this.id = id;
            this.userId = userId;
            this.filmId = filmId;
            this.roomId = roomId;
            this.dateBought = dateBought;
            this.dateFilm = dateFilm;
            this.hourFilm = hourFilm;
            this.quantity = quantity;
            this.individualPrice = individualPrice;
            this.discount = discount;
        }

        /// <summary>
        /// Obtiene el usuario del ticket
        /// </summary>
        /// <returns>Un objeto usuario</returns>
        public User getUser()
        {
            return User.InfoUser(userId);
        }

        /// <summary>
        /// Obtiene la pelicula del ticket
        /// </summary>
        /// <returns>Un objeto pelicula</returns>
        public Film getFilm()
        {
            return Film.InfoFilm(filmId);
        }

        /// <summary>
        /// Obtiene la sala del ticket
        /// </summary>
        /// <returns>Un objeto sala</returns>
        public Room getRoom()
        {
            return Room.InfoRoom(roomId);
        }

        /// <summary>
        /// Inserts the Ticket into the Database
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO tickets (userId, filmId, roomId, dateBought, dateFilm, hourFilm, quantity, individual_price, discount) VALUES (@userId, @filmId, @roomId, @dateBought, @dateFilm, @hourFilm, @quantity, @individualPrice, @discount)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@filmId", filmId);
            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@dateBought", dateBought);
            command.Parameters.AddWithValue("@dateFilm", dateFilm);
            command.Parameters.AddWithValue("@hourFilm", hourFilm);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@individualPrice", individualPrice);
            command.Parameters.AddWithValue("@discount", discount);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Obtiene un ticket de la base de datos en base a su ID
        /// </summary>
        /// <param name="id">El ID del ticket</param>
        /// <returns>Un objeto ticket</returns>
        public static Ticket Obtain(int id)
        {
            string query = "SELECT * FROM tickets WHERE id LIKE @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Ticket ticket = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    ticket = new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return ticket;
        }

        /// <summary>
        /// Obtiene el precio total del ticket sin descuento, contando la cantidad comprada
        /// </summary>
        /// <returns>Precio total del ticket sin descuento</returns>
        public double TotalPriceWithoutDiscount()
        {
            return individualPrice * quantity;
        }

        /// <summary>
        /// Obtiene el precio total con descuento del ticket
        /// </summary>
        /// <returns>Precio total</returns>
        public double TotalPrice()
        {
            return TotalPriceWithoutDiscount() - PriceDiscounted();
        }
        
        /// <summary>
        /// Obtiene la cantidad que se descuenta del ticket
        /// </summary>
        /// <returns>Cantidad que se descuenta</returns>
        public double PriceDiscounted()
        {
            return TotalPriceWithoutDiscount() * DiscountDivided();
        }

        /// <summary>
        /// Obtiene el descuento en formato operable (ej: 0.15)
        /// </summary>
        /// <returns>Descuento operable</returns>
        public double DiscountDivided()
        {
            return discount / 100d;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> Tickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de las peliculas que todavia no han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> ActualTickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId AND dateFilm >= @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de la pelicula especificada que todavia no han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <param name="filmName">Id de la pelicula</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> ActualTickets(int userId, string filmName)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId AND dateFilm >= @date AND filmId IN (SELECT id FROM films WHERE name LIKE @filmName)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@filmName", $"%{filmName}%");

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de las peliculas que ya han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> PastTickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId AND dateFilm < @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de la pelicula especificada que ya han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <param name="filmName">Id de la pelicula</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> PastTickets(int userId, string filmName)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = $"SELECT * FROM tickets WHERE userId = @userId AND dateFilm < @date AND filmId IN (SELECT id FROM films WHERE name LIKE @filmName)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@filmName", $"%{filmName}%");

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetTimeSpan(6),
                        reader.GetInt32(7),
                        reader.GetDouble(8),
                        reader.GetInt32(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

            /// <summary>
            /// Obtiene la cantidad de tickets actuales que tiene un usuario
            /// </summary>
            /// <param name="userId">El ID del usuario</param>
            /// <returns>Cantidad de tickets</returns>
            public static int AmountActualTickets(int userId)
        {
            string query = "SELECT COUNT(*) FROM tickets WHERE userId = @userId AND dateFilm >= @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene la cantidad de tickets pasados que tiene un usuario
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Cantidad de tickets</returns>
        public static int AmountPastTickets(int userId)
        {
            string query = "SELECT COUNT(*) FROM tickets WHERE userId = @userId AND dateFilm < @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene el porcentaje de descuento para la cantidad de tickets introducida (ejemplo: 15)
        /// </summary>
        /// <param name="amountTickets">Cantidad de tickets que se van a comprar</param>
        /// <returns>Porcentaje de descuento</returns>
        public static int AmountDiscount(int amountTickets)
        {
            if (amountTickets == 2)
            {
                return 10;
            }
            else if (amountTickets == 3)
            {
                return 15;
            }
            else if (amountTickets >= 4)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Obtiene el porcentaje / 100 de descuento para la cantidad de tickets introducida (ejemplo: 0.15)
        /// </summary>
        /// <param name="amountTickets">Cantidad de tickets que se van a comprar</param>
        /// <returns>Porcentaje / 100 de descuento</returns>
        public static double DiscountDivided(int amountTickets)
        {
            return AmountDiscount(amountTickets) / 100d;
        }

        /// <summary>
        /// Obtiene el precio total del ticket en base al precio base de la pelicula, cantidad de tickets y el descuento aplicado
        /// </summary>
        /// <param name="filmPrice">El precio base de la pelicula</param>
        /// <param name="amountTickets">Cantidad de tickets a comprar</param>
        /// <returns>El precio total del ticket</returns>
        public static double AmountTotalPrice(double filmPrice, int amountTickets)
        {
            double priceTickets = filmPrice * amountTickets;

            return priceTickets - (priceTickets * DiscountDivided(amountTickets));
        }
    }
}
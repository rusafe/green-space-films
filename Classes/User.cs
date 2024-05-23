using MySql.Data.MySqlClient;
using ProyectoGreenSpace.Classes;
using System;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoGreenSpace
{
    class User
    {
        // Atributos 
        private int id;
        private string username;
        private string password;
        private string repeatPassword;
        private string mail;
        private Image pfp;
        private bool admin;
        private DateTime creationDateTime;

        // Métodos de acceso 
        public int Id { get { return id; } set { id = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string RepeatPassword { get { return repeatPassword; } set { { repeatPassword = value; } } }
        public string Mail { get { return mail; } set { mail = value; } }
        public Image Pfp { get { return pfp; } set { pfp = value; } }
        public bool Admin { get { return admin; } set { admin = value; } }
        public DateTime CreationDateTime { get { return creationDateTime; } set { creationDateTime = value; } } 

        // Constructores
        public User() { }

        public User(int id, string username, string password, string mail, Image pfp, bool admin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.mail = mail;
            this.pfp = pfp;
            this.admin = admin;
        }

        /// <summary>
        /// Nos permite registrar un usuario a la base de datos.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <returns></returns>
        public int RegisterUser()
        {
            int result;

            string query = "INSERT INTO users (username, password, mail) " +
            "VALUES (@username, @password, @mail)";

            ConnectionBD.OpenConnection();
            using (MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@mail", mail);
                // (2) Para registrar como usuario del sistema.
                result = command.ExecuteNonQuery();
            }
            ConnectionBD.CloseConnection();

            return result;
        }

        /// <summary>
        /// Delete a user from the database given its Id
        /// </summary>
        /// <param name="id">The user Id</param>
        public static void Delete(int id)
        {
            string query = "DELETE FROM users WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Nos permite comprobar la existencia del usuario mediante el nombre de usuario.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <returns> True si existe el usuario, false sino existe el usuario. </returns>
        public static bool ExistUser(string username)
        {
            string query = "SELECT id FROM users WHERE username = @username";

            bool exist;

            ConnectionBD.OpenConnection();
            using (MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    exist = reader.HasRows;
                }
            }
            ConnectionBD.CloseConnection();

            return exist;
        }

        public static User InfoUser(string username)
        {
            string query = "SELECT * FROM users WHERE username LIKE @username";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@username", username);

            User user = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    user = new User();
                    user.username = reader["username"].ToString();
                    user.id = Convert.ToInt32(reader["id"]);
                    user.password = reader["password"].ToString();
                    user.mail = reader["mail"].ToString();
                    user.admin = Convert.ToBoolean(reader["admin"]);
                    user.creationDateTime = Convert.ToDateTime(reader["creationDateTime"]);
                }
            }
            ConnectionBD.CloseConnection();
            return user;
        }

        public static User InfoUser(int id)
        {
            string query = "SELECT * FROM users WHERE id LIKE @id";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            User user = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    user = new User(
                        Convert.ToInt32(reader["id"]),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["mail"].ToString(),
                        reader.GetSafeImage(5),
                        Convert.ToBoolean(reader["admin"])
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return user;
        }

        public void UpdatePassword(string newPassword, MySqlDataReader reader)
        {
            string updateQuery = "UPDATE users SET password = @newPassword WHERE username = @username";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, ConnectionBD.Connection);

            updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
            updateCommand.Parameters.AddWithValue("@username", Username);
            reader.Close();
            updateCommand.ExecuteNonQuery();
        }

        public static bool CheckPassword(string username, string password)
        {
            bool check = false;

            string query = String.Format("SELECT password FROM users WHERE username = @username");
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@username", username);

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Controller passwordCifrated = new Controller();
                    if (reader["password"].ToString() == password)
                    {
                        check = true;
                    }
                }
            }
            ConnectionBD.CloseConnection();
            return check;
        }

        public static bool IsAdministrator(string username)
        {
            bool isAdmin = false;
            string query = String.Format("SELECT admin FROM users WHERE username = @username");
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@username", username);

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    isAdmin = Convert.ToBoolean(reader["admin"]);
                }
            }
            ConnectionBD.CloseConnection();
            return isAdmin;
        }
}
}
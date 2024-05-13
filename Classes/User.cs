using MySql.Data.MySqlClient;
using System;

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
        private int idType;

        // Métodos de acceso 
        public int Id { get { return id; } set { id = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string RepeatPassword { get { return repeatPassword; } set { { repeatPassword = value; } } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int IdType { get { return idType; } set { idType = value; } }

        // Constructores
        public User() { }

        /// <summary>
        /// Nos permite registrar un usuario a la base de datos.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <returns></returns>
        public int RegisterUser(MySqlConnection connection)
        {
            int result;

            string query = "INSERT INTO users (username, password, mail, id_type) " +
            "VALUES (@username, @password, @mail, @id_type)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@id_type", 2);             // (1) Para registrar como administrador del sistema.
                                                                            // (2) Para registrar como usuario del sistema.
                result = command.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// Nos permite comprobar la existencia del usuario mediante el nombre de usuario.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <returns> True si existe el usuario, false sino existe el usuario. </returns>
        public static bool ExistUser(MySqlConnection connection, string username)
        {
            string query = "SELECT id FROM users WHERE username = @username";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public static User InfoUser(MySqlConnection conexion, string username)
        {
            string consulta = "SELECT * FROM users WHERE username LIKE @username";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@username", username);

            User user = null;

            using (MySqlDataReader reader = comando.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    user = new User();
                    user.username = reader["username"].ToString();
                    user.id = Convert.ToInt32(reader["id"].ToString());
                    user.password = reader["password"].ToString();
                    user.mail = reader["mail"].ToString();
                    user.idType = Convert.ToInt32(reader["id_type"].ToString());
                }
            }
            return user;
        }
    }
}
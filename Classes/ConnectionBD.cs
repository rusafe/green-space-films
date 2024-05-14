using MySql.Data.MySqlClient;

namespace ProyectoGreenSpace
{

    // Clase para gestionar las operaciones con la Base de Datos
    static class ConnectionBD
    {
        // Atributo para gestionar la conexión.
        private static MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=GreenSpaceFilms;uid=root;pwd=;Convert Zero Datetime=True;");

        // Propiedad para acceder a la conexión.
        public static MySqlConnection Connection { get { return connection; } }

        // Método que se encarga de abrir la conexión
        // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
        public static bool OpenConnection()
        {
            // Controlamos la expeción si es true, se ha abierto correctamente,
            // sino ya teníamos abierta la conexión o tenemos un error.
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)  // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }

        // Método que se encarga de cerrar la conexión (evitar dejar conexiones abiertas)
        // Devuelve true/false dependiendo si la conexión se ha cerrado con éxito
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }

    }
}
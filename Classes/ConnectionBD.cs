using MySql.Data.MySqlClient;

namespace ProyectoGreenSpace
{

    // Clase para gestionar las operaciones con la Base de Datos
    class ConnectionBD
    {
        // Atributo para gestionar la conexión.
        private MySqlConnection connection;

        // Propiedad para acceder a la conexión.
        public MySqlConnection Connection { get { return connection; } }

        // Constructor que instancia la conexión, definiendo la cadena de conexión (ConnectionString).
        public ConnectionBD()
        {
            // Conexión Local
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=GreenSpaceFilms;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string convertDateTimeNull = "Convert Zero Datetime=True;";
            string connectionString = server + port + database + usuario + password + convertDateTimeNull;

            // Instanciación de un constructor de la claseMySqlConnection,
            // que le pasamos el connectionString para realizar la conexión a la base de datos.
            connection = new MySqlConnection(connectionString);

            // Ejemplo de Conexión remota: db4free.net
            //string server = "server=db4free.net;";
            //string oldguids = "oldguids=true;";
            //string database = "database=bdsalva;";
            //string usuario = "uid=salvador;";
            //string password = "pwd=;";
            //string connectionstring = server + oldguids + database + usuario + password;
        }

        // Método que se encarga de abrir la conexión
        // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
        public bool AbrirConexion()
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
        public bool CerrarConexion()
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
using MySql.Data.MySqlClient;
using System.Security.Cryptography; // Utilizada para la encriptación
using System.Text;

namespace ProyectoGreenSpace
{
    class Controller
    {
        /// <summary>
        /// Controlar validaciones y posteriormente registrar al usuario, una vez todo está correcto.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <param name="user"> Objeto cargado con la información de la interface para registrarlo. </param>
        /// <returns> Un mensaje con el usuario registrado o la falta de una validación. </returns>
        public string ControllerRegister(MySqlConnection connection, User user)
        {

            string respuesta = "";

            // Primera validación: comprobar que todos los campos no estén vacíos.
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.RepeatPassword) || string.IsNullOrEmpty(user.Mail))
            {
                respuesta = "Error, rellena todos los campos.";
            }
            else
            {
                if (user.Password != user.RepeatPassword)
                {
                    respuesta = "Las contraseñas no coinciden.";
                }
                else
                {
                    if (User.ExistUser(connection, user.Username))
                    {
                        respuesta = "El usuario ya existe.";
                    }
                    else
                    {
                        user.Password = GenerateSHA1(user.Password);
                        user.RegisterUser(connection);
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Controlar validaciones y posteriormente iniciar sesión con el usuario, una vez todo está correcto.
        /// </summary>
        /// <param name="connection"> Conexión a la base de datos. </param>
        /// <param name="user"> Objeto cargado con el nombre de usuario y la contraseña con la información de la interface para registrarlo. </param>
        /// <returns> Un mensaje con el usuario iniciado o la falta de una validación. </returns>
        public string ControllerLogin(MySqlConnection connection, User user)
        {

            string respuesta = "";
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                respuesta = "Error, rellena todos los campos.";
            }
            else
            {
               User data = User.InfoUser(connection, user.Username); // Cargar toda la información del usuario.
                if (!User.ExistUser(connection, user.Username))
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (data.Password != GenerateSHA1(user.Password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden.";
                    } else
                    {
                        Session.Id = data.Id;
                        Session.Username = data.Username;
                        Session.Password = data.Password;
                        Session.IdType = data.IdType;
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Generar contraseña cifrada SHA1 para almacenar la información en la base de datos.
        /// </summary>
        /// <param name="password"> Contraseña que vamos a cifrar. </param>
        /// <returns> Contraseña cifrada en código hexadecimal. </returns>
        private string GenerateSHA1(string password)
        {
            // Instanciamos un objeto de la clase UTF8Encoding,
            // necesario para convertir la cadena que pasamos por parámetro en bytes formato UTF-8.
            UTF8Encoding encoding = new UTF8Encoding();

            // Declaramos un vector de bytes para convertir la contraseña en bytes.
            byte[] data = encoding.GetBytes(password);
            byte[] result;

            // Instanciación de un objeto Sha1 de la clase SHA1, necesario para utiliar sus métodos y calcular el hash.
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            // Calculamos el valor del hash mediante el vector de datos en byte.
            result = sha1.ComputeHash(data);

            // Instancación de un objeto sb de la clase StringBuilder
            // nos permite hacer la representación hexadecimal del hash calculado en caracteres.
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                // Si el byte del hash no tiene dos digitos con el método Append añadimos el dígito 0 delante,
                // nos aseguramos que el hash tenga valores hexadecimales. 
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                // Traduce el valor de cada byte hexadecimal en su representación de cadena, cada byte es representado por un carácter.
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
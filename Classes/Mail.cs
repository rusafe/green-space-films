using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ProyectoGreenSpace
{
    class Mail
    {
        /// <summary>
        /// Envio de correo de verificación a un usuario con código de verificación aleatorio para comprobar que el correo es el correcto.
        /// </summary>
        /// <param name="mailTransmitter"> Quien envia el correo (Administrador) </param>
        /// <param name="password"> Contraseña de administrador </param>
        /// <param name="mailReceiver"> Quien recibe el correo (Usuario) </param>
        /// <returns> El código de verificación </returns>
        public int SendVerificationCode(string mailTransmitter, string password, string mailReceiver)
        {
            Random rand = new Random();
            int randomCode = rand.Next(100000, 1000000); // Min value 100.000, máximo valor 1.000.000

            MailMessage message = new MailMessage();
            message.To.Add(mailReceiver); // Dirigido al receptor
            message.Subject = "Correo de verificación.";
            message.SubjectEncoding = Encoding.UTF8; // Necesario declara UTF8.
            message.Body = "Estimado/a usuario/a,\n\rPara completar el registro en Green Space Films, introduzca el siguiente código de verificación " +
                "dentro de la aplicación:\n\rSu código de verificación es: " + randomCode + ".\n\rGracias por elegir Green Space Films." +
                "\n\rAtentamente,\n\tEl equipo de Green Space Films";
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = false;
            message.From = new MailAddress(mailTransmitter);

            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(mailTransmitter, "ciag qpjz znej msjw");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // randomCode = -1;
            }
            return randomCode;
        }

        public void SendRecoveryPassword(string mailTransmitter, string password, string mailReceiver)
        {
            MailMessage message = new MailMessage();
            message.To.Add(mailReceiver); // Dirigido al receptor
            message.Subject = "Correo de recuperación de contraseña.";
            message.SubjectEncoding = Encoding.UTF8; // Necesario declara UTF8.
            message.Body = "Estimado/a usuario/a, \n\rHa solicitado recuperar su contraseña. " +
                "Su nueva contraseña generada es: " + password + ".\n\rGracias por elegir Green Space Films." +
                "\n\rAtentamente,\n\tEl equipo de Green Space Films";
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = false;
            message.From = new MailAddress(mailTransmitter);

            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(mailTransmitter, "ciag qpjz znej msjw");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // randomCode = -1;
            }
        }

        public void RecoverPassword(string username)
        {
            User recoverPassword = new User();
            recoverPassword.Username = username;

            Controller cifratePassword = new Controller();

            string query = "SELECT mail, password FROM users WHERE username = @username";
            ConnectionBD.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@username", username);
            
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string mail = reader["mail"].ToString();
                    string password = GenerateRandomPassword(); // Generar nueva contraseña
                    string newPassword = Convert.ToString(cifratePassword.GenerateSHA1(password));

                    recoverPassword.UpdatePassword(newPassword, reader); // Actualizar contraseña
                    SendRecoveryPassword("floadm123@gmail.com", password, mail); // Mandar una nueva contraseña
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
            ConnectionBD.CloseConnection();
        }

        private string GenerateRandomPassword()
        {
            int length = 8;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder password = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                password.Append(chars[rand.Next(chars.Length)]);
            }

            return password.ToString();
        }
    }
}
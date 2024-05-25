using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace
{
    class UserSession
    {
        private static int id;
        private static string username;
        private static string password;
        private static bool admin;
        private static string mail;
        private static DateTime creationDateTime;


        public static int Id { get { return id; } set { id = value; } }
        public static string Username { get { return username; } set { username = value; } }
        public static string Password { get { return password; } set { password = value; } }
        public static bool Admin { get { return admin; } set { admin = value; } }
        public static string Mail { get { return mail; } set { mail = value; } }
        public static DateTime CreationDateTime { get {  return creationDateTime; } set {  creationDateTime = value; } }
        
        /// <summary>
        /// Borra el usuario con la sesion iniciada de la base de datos
        /// </summary>
        public static void DeleteUser()
        {
            User.Delete(id);
        }
    }
}
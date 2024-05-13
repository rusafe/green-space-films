using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace
{
    class Session
    {
        private static int id;
        private static string username;
        private static string password;
        private static int idType;

        public static int Id { get { return id; } set { id = value; } }
        public static string Username { get { return username; } set { username = value; } }
        public static string Password { get { return password; } set { password = value; } }
        public static int IdType { get { return idType; } set { idType = value; } }

    }
}

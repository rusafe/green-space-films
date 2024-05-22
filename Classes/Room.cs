using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal class Room
    {
        private int id;
        private string type;

        public int Id { get { return id; } }
        public string Type { get { return type; } }

        public Room(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        public static Room InfoRoom(int id)
        {
            string query = "SELECT * FROM rooms WHERE id LIKE @id";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Room room = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    room = new Room(
                        reader.GetInt32(0),
                        reader.GetString(1)
                    );
                }
            }
            ConnectionBD.CloseConnection();

            return room;
        }

        public static List<int> GetIdentifyingInfo()
        {
            List<int> list = new List<int>();

            string query = "SELECT id FROM rooms";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    list.Add(
                        reader.GetInt32(0)
                    );
                }
            }

            ConnectionBD.CloseConnection();

            return list;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal class Film
    {
        private int id;
        private string name;
        private string synopsis;
        private Image image;
        private TimeSpan duration;
        private int minAge;
        private double price;
        private List<string> genres;
        private bool priemering;

        public Film(int id, string name, string synopsis, Image image, TimeSpan duration, int minAge, double price, List<string> genres, bool priemering)
        {
            this.id = id;
            this.name = name;
            this.synopsis = synopsis;
            this.image = image;
            this.duration = duration;
            this.minAge = minAge;
            this.price = price;
            this.genres = genres;
            this.priemering = priemering;
        }

        //public Double TotalScore()
        //{
        //    string queryString = "SELECT AVG(score) FROM reviews WHERE fimlId = @film";

        //    MySqlCommand command = new MySqlCommand(queryString, ConnectionBD.Connection);
        //}
    }
}

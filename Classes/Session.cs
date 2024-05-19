using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal class Session
    {
        private int id;
        private int filmId;
        private int roomId;
        private TimeSpan startHour;
        private int totalSeats;
        private int occupiedSeats;

        public TimeSpan StartHour { get { return startHour; } }

        public Session(int id, int filmId, int roomId, TimeSpan startHour, int totalSeats, int occupiedSeats)
        {
            this.id = id;
            this.filmId = filmId;
            this.roomId = roomId;
            this.startHour = startHour;
            this.totalSeats = totalSeats;
            this.occupiedSeats = occupiedSeats;
        }

        /// <summary>
        /// Obtiene la pelicula de la sesion
        /// </summary>
        /// <returns>Un objeto pelicula</returns>
        public Film getFilm()
        {
            return Film.InfoFilm(filmId);
        }

        /// <summary>
        /// Obtiene la sala de la sesion
        /// </summary>
        /// <returns>Un objeto sala</returns>
        public Room getRoom()
        {
            return Room.InfoRoom(roomId);
        }

        public int FreeSeats()
        {
            return totalSeats - occupiedSeats;
        }
    }
}

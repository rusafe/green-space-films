using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal class Seat
    {
        bool occupied;
        bool selected;

        public bool Occupied { get { return occupied; } set { occupied = value; } }
        public bool Selected { get { return selected; } set { selected = value; } }

        public Seat()
        {
            this.occupied = false;
            this.selected = false;
        }

        public Seat(bool occupied)
        {
            this.occupied = occupied;
            this.selected = false;
        }

        public Seat(bool occupied, bool selected)
        {
            this.occupied = occupied;
            this.selected = selected;
        }

        public void ChangeSelectedStatus()
        {
            selected = !selected;
        }
    }
}

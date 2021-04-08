using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    [Serializable] public class Room : ICloneable, IComparable<Room>
    {
        private int id;
        private int capacity;
        private double price;
        private bool isPremium;

        public bool IsPremium { get => isPremium; set => isPremium = value; }
        public double Price
        {
            get => price;
            set { if (value > 0) price = value; }
        }
        public int Capacity
        {
            get => capacity;
            set { if (value > 0 && value < 4) capacity = value; }
        }
        public int Id
        {
            get => id;
            set { if (value > 0) id = value; }
        }

        public override string ToString()
        {
            return String.Format("Camera {0} - capacitate {1} - pret {2} - {3}",
                id,
                capacity,
                price,
                isPremium ? "este premium" : "nu este premium"
               );
        }

        public Room(int id, int capacity, double price, bool isPremium)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Price = price;
            this.isPremium = isPremium;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static Room operator +(Room r, double p) {
            r.price += p;
            return r;
        }

        public static Room operator +(double p, Room r)
        {
            return r + p;
        }

        public int CompareTo(Room room)
        {
            return this.id.CompareTo(room.id);
        }
    }
}

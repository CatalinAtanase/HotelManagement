using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Room
    {
        private int id;
        private int capacity;
        private double price;
        private bool isPremium;
        private bool isBooked;

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

        public bool IsBooked { get => isBooked; set => isBooked = value; }

        public override string ToString()
        {
            return String.Format("Camera {0} - capacitate {1} - pret {2} - {3} - {4}",
                id,
                capacity,
                price,
                isPremium ? "este premium" : "nu este premium",
                isBooked ? "este inchiriata" : "nu este inchiriata");
        }

        public Room(int id, int capacity, double price, bool isPremium, bool isBooked)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Price = price;
            this.isPremium = isPremium;
            this.IsBooked = isBooked;
        }


    }
}

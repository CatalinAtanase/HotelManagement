using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    [Serializable]
    public class Booking: IComparable<Booking>, ICloneable
    {
        User user;
        Room room;
        DateTime startDate;
        DateTime endDate;

        public Booking(User user, Room room, DateTime startDate, DateTime endDate)
        {
            this.user = user;
            this.Room = room;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate
        {
            get => endDate;
            set { if (DateTime.Compare(value, startDate) > 0) endDate = value; }
        }

        public Room Room { get => room; set => room = value; }
        internal User User { get => user; set => user = value; }

        public int CompareTo(Booking obj)
        {
            return startDate.CompareTo(obj.startDate);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public double getValoareTotala()
        {
            return getNumberOfDays() * room.Price;
        }

        public int getNumberOfDays()
        {
            return (int)(endDate - startDate).TotalDays;
        }

        public override string ToString()
        {
            string response = "Rezervare pentru:  \n" + user + "\n";
            response += "Camera " + Room;
            response += "\nIncepe la " + startDate.ToLocalTime() + " si se termina la " + endDate + "\n";
            return response;

        }
    }
}

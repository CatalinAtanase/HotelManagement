using HotelManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    [Serializable]
    public class Booking: IComparable<Booking>, ICloneable, IPrice
    {
        string userCNP;
        int roomId;
        DateTime startDate;
        DateTime endDate;
        int[] rooms;

        public Booking(string userCNP, int roomId, DateTime startDate, DateTime endDate, int[] rooms) : this(userCNP, roomId, startDate, endDate)
        {
            this.rooms = rooms;
        }

        public Booking(string userCNP, int roomId, DateTime startDate, DateTime endDate)
        {
            this.UserCNP = userCNP;
            this.RoomId = roomId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.Rooms = null;
        }

        public int NrRooms
        {
            get
            {
                return Rooms != null ? this.Rooms.Length : 0;
            }
        }

        public int this[int index]
        {
            get
            {
                if (Rooms != null && index >= 0 && index < Rooms.Length)
                    return Rooms[index];
                else
                    return -1;
            }
        }


        public object Clone()
        {
            return ((ICloneable)this).Clone();
        }

        public static Booking operator +(Booking b, int roomNumber)
        {
            Booking copy = (Booking)b.Clone();
            if(copy.Rooms != null)
            {
                int[] newRooms = new int[copy.Rooms.Length + 1];
                copy.Rooms.CopyTo(newRooms, 0);
                newRooms[newRooms.Length - 1] = roomNumber;
                copy.Rooms = newRooms;
            } else
            {
                copy.Rooms = new int[1];
                copy.Rooms[0] = roomNumber;
            }

            return copy;
        }

        public static Booking operator +(int roomNumber, Booking b)
        {
            return b + roomNumber;
        }



        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate
        {
            get => endDate;
            set { if (DateTime.Compare(value, startDate) > 0) endDate = value; }
        }

        public string UserCNP { get => userCNP; set => userCNP = value; }
        public int RoomId { get => roomId; set => roomId = value; }
        public int[] Rooms { get => rooms; set => rooms = value; }

        public int CompareTo(Booking obj)
        {
            return (obj.roomId == this.roomId && obj.startDate == this.startDate && obj.endDate == this.endDate && obj.userCNP == this.userCNP) ? 1 : 0;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public double getTotalPrice(List<Room> rooms)
        {
            Room room = rooms.FirstOrDefault(r => r.Id == roomId);
            if(room != null)
            {
                return getNumberOfDays() * room.Price;
            }
            return 0;
        }

        public int getNumberOfDays()
        {
            return (int)(endDate - startDate).TotalDays;
        }

        public string getAllRooms()
        {
            string response = "";
            for(int i = 0; i < this.NrRooms; i++)
            {
                response += this.Rooms[i].ToString();
                if (i != this.NrRooms - 1) response += ", ";
            }

            return response;
        }

        public override string ToString()
        {
            string response = "Rezervare pentru:  \n" + userCNP + "\n";
            response += "Camere: ";
            for (int i = 0; i < this.NrRooms; i++)
            {
                response += this.Rooms[i] + ", ";
            }
            response += "\nIncepe la " + startDate.ToLocalTime() + " si se termina la " + endDate + "\n";
            return response;

        }
    }
}

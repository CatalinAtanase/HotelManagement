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
        string userCNP;
        int roomId;
        DateTime startDate;
        DateTime endDate;

        public Booking(string userCNP, int roomId, DateTime startDate, DateTime endDate)
        {
            this.UserCNP = userCNP;
            this.RoomId = roomId;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate
        {
            get => endDate;
            set { if (DateTime.Compare(value, startDate) > 0) endDate = value; }
        }

        public string UserCNP { get => userCNP; set => userCNP = value; }
        public int RoomId { get => roomId; set => roomId = value; }

        //public int CompareTo(Booking obj)
        //{
        //    return startDate.CompareTo(obj.startDate);
        //}

        public int CompareTo(Booking obj)
        {
            return (obj.roomId == this.roomId && obj.startDate == this.startDate && obj.endDate == this.endDate && obj.userCNP == this.userCNP) ? 1 : 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //public double getValoareTotala()
        //{
        //    return getNumberOfDays() * room.Price;
        //}

        public int getNumberOfDays()
        {
            return (int)(endDate - startDate).TotalDays;
        }

        public override string ToString()
        {
            //string response = "Rezervare pentru:  \n" + user + "\n";
            //response += "Camera " + Room;
            //response += "\nIncepe la " + startDate.ToLocalTime() + " si se termina la " + endDate + "\n";

            string response = "Rezervare pentru:  \n" + userCNP + "\n";
            response += "Camera " + roomId;
            response += "\nIncepe la " + startDate.ToLocalTime() + " si se termina la " + endDate + "\n";
            return response;

        }
    }
}
